using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobAlunosFuncionarios
{
    internal class Funcionario : Pessoas
    {
        int NumPIS;
        double Salario;
        String Cargo;

        public Funcionario(String nome, int dataNasc, int cpf, int numPIS, double salario, string cargo)
            : base(nome, dataNasc, cpf)
        {
            NumPIS = numPIS;
            Salario = salario;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return base.ToString() + "\nNumero do PIS: " + NumPIS + "\n" +
                "Salario: " + Salario + "\n" +
                "Cargo: " + Cargo;
        }
    }
}





