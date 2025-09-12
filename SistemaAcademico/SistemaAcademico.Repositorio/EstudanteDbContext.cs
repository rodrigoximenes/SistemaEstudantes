using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
