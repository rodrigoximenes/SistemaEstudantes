using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Servico;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{ 
    options.AddPolicy("AllowFrontend",
    policy => policy
    .WithOrigins("http://localhost:4200")
    .AllowAnyHeader()
    .AllowAnyMethod()
    );
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurando InMemory DB
builder.Services.AddDbContext<EstudanteDbContext>(options =>
    options.UseInMemoryDatabase("EstudanteDb"));

builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
builder.Services.AddScoped<IAlunoServico, AlunoServico>();

var app = builder.Build();
app.UseCors("AllowFrontend");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
