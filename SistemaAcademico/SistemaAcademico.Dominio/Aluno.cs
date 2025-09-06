using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public float Nota { get; set; }

        public bool EhMaiorIdade()
        {
            return this.Idade >= 18;
        }

        public bool EstaAprovado()
        {
            return this.Nota >= 7;
        }
    }
}
