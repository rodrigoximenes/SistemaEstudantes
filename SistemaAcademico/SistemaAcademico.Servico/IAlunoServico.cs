using SistemaAcademico.Dominio;

namespace SistemaAcademico.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
    }
}
