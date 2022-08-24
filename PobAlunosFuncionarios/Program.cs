using System;

namespace PobAlunosFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno1= new Aluno("Luciano",05022001,447652,45612398,05022001);
            Console.WriteLine(Aluno1.ToString());
            Console.WriteLine();

            Funcionario Fun1 = new Funcionario("Henrique", 08062006, 123456, 976543125, 1500.00,"Genrente de Tecnologia");
            Console.WriteLine(Fun1.ToString()); 

          //  Lazy<Aluno> Lazy = new Lazy<Aluno>(() => Aluno);
        }
    }
}
