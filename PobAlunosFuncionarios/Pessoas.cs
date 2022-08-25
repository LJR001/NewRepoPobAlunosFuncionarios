using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobAlunosFuncionarios
{
    internal class Pessoas
    {
        String Nome;
        int DataNasc;
        long Cpf;
       /* public Pessoas()
        {

        }*/
       public Pessoas(String nome, int dataNasc, long cpf)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;  
            this.Cpf = cpf;
        }
        public override string ToString()
        {
            return "Nome: "+this.Nome+"\n" +
                "Data de Nascimento: "+this.DataNasc+/*ToLongDateString()+*/"\n" +
                "CPF: "+this.Cpf; 
        }
        public void setNome()
        {
            String nome = Console.ReadLine();
            this.Nome = nome;
        }
        public void getNome()
        {
            Console.WriteLine(this.Nome);
        }

        public void setDataNasc()
        {
            int dataNasc =int.Parse(Console.ReadLine());
            this.DataNasc = dataNasc;
        }
        public void getDataNasc()
        {
            Console.WriteLine(this.DataNasc);
        }


        public void setCpf()
        {
            long cpf = long.Parse(Console.ReadLine());
            this.Cpf = cpf;
        }
        public void getCpf()
        {
            Console.WriteLine(this.Cpf);
        }

    }
   
}
