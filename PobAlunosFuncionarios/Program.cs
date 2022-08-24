using System;

namespace PobAlunosFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas("Luciano",05022001,447652);
            Console.WriteLine(pessoa1.ToString());
        }
    }
}
