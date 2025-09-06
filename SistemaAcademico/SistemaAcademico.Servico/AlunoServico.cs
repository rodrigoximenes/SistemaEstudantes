using SistemaAcademico.Dominio;
using SistemaAcademico.Repositorio;

namespace SistemaAcademico.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("O nome do aluno é obrigatório.");

            _repositorio.Adicionar(aluno);
        }

        public List<Aluno> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
