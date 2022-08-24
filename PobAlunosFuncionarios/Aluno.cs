using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobAlunosFuncionarios
{
    internal class Aluno:Pessoas
    {
        int Ra;
        int DataMatricula;

        public Aluno(String nome, int dataNasc, long cpf, int ra, int dataMatricula) : base(nome, dataNasc, cpf)
        {
            Ra = ra;
            DataMatricula = dataMatricula;
        }
        public override string ToString()
        {
            return base.ToString() + "\nRa: " + Ra + "\n" +
                "Data de Matricula " + DataMatricula;
        }
    }
}
