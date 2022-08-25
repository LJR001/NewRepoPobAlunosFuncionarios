using System;

namespace PobAlunosFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ************ Cadastro de pessoas ***********");
            Console.WriteLine("\nDigite se você quer adicionar 'aluno' ou 'funcionario'");
            string opcao = Console.ReadLine();
           
            Console.Clear();

            
            Console.Write("\nDigite o NOME: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o DATA DE NASCIMENTO: ");
            int datanasc = int.Parse(Console.ReadLine());
            Console.Write("Digite o CPF: ");
            long CPF = long.Parse(Console.ReadLine());

            if (opcao == "funcionario")
            {
                
                Console.Write("Digite o PIS: ");
                int pis = int.Parse(Console.ReadLine());
                Console.Write("Digite o Salario: ");
                float salario = float.Parse(Console.ReadLine());
                Console.Write("Digite o Cargo");
                string cargo = Console.ReadLine();

                Console.WriteLine("Aperte ENTER para ver os funcionarios adicionados");
                Console.ReadKey();
                Console.Clear();

                Console.Write("Funcionario\n");
                Funcionario fun2 = new Funcionario(nome, datanasc, CPF, pis, salario,cargo);
                Console.WriteLine(fun2.ToString());
                Console.WriteLine();
            }
            else
            {
                Console.Write("Digite o RA: ");
                int ra = int.Parse(Console.ReadLine());
                Console.Write("Digite a Data de matricula: ");
                int datamat = int.Parse(Console.ReadLine());

                Console.Write("\n Cadastro Finalizado!!!\n Aperte ENTER para ver os funcionarios adicionados");
                Console.ReadKey();
                Console.Clear();

                Console.Write("Aluno\n");
                Aluno aluno2 = new Aluno(nome, datanasc, CPF, ra, datamat);
                Console.WriteLine(aluno2.ToString());
                Console.WriteLine();
            }

            Console.Write("Aluno\n");
            Aluno aluno1 = new Aluno("Luciano", 05022001, 447652, 45612398, 05022001);
            Console.WriteLine(aluno1.ToString());
            Console.WriteLine();

            Console.Write("Funcionario\n");
            Funcionario fun1 = new Funcionario("Henrique", 08062006, 123456, 976543125, 1500.00, "Genrente de Tecnologia");
            Console.WriteLine(fun1.ToString());
            Console.WriteLine();





            //  Lazy<Aluno> Lazy = new Lazy<Aluno>(() => Aluno);
        }
    }
}
