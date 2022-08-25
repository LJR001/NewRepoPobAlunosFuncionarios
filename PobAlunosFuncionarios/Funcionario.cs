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

        public Funcionario(String nome, int dataNasc, long cpf, int numPIS, double salario, string cargo)
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

        public void setNumPIS()
        {
            int numPis = int.Parse(Console.ReadLine());
            this.NumPIS = numPis;
        }
        public void getNumPIS()
        {
            Console.WriteLine(this.NumPIS);
        }


        public void setSalario()
        {
            double salario = double.Parse(Console.ReadLine()); 
            this.Salario = salario;
        }
        public void getSalario()
        {
            Console.WriteLine(this.Salario);
        }


        public void setCargo()
        {
            String cargo = Console.ReadLine();
            this.Cargo = cargo;
        }
        public void getCargo()
        {
            Console.WriteLine(this.Cargo);
        }
      
    }

}





