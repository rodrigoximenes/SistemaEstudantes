using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly EstudanteDbContext _context;

        public AlunoRepositorio(EstudanteDbContext contexto)
        {
            _context = contexto;
        }

        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public List<Aluno> Listar()
        {
            return _context.Alunos.ToList();
        }
    }
}
