using System;

namespace PobAlunosFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Fun1 = new Funcionario("Luciano",05022001,447652,45612398,05022001);
            Console.WriteLine(Fun1.ToString());
        }
    }
}
