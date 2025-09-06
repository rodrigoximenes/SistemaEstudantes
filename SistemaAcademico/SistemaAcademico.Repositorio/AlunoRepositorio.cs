using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private static List<Aluno> _alunos = new();

        public void Adicionar(Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public List<Aluno> Listar()
        {
            return _alunos;
        }
    }
}
