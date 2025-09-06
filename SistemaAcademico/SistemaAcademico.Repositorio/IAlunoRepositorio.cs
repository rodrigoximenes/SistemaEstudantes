using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
    }
}
