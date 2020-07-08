using System;
using System.Globalization;

namespace classe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa1 = new Funcionario();
            Funcionario pessoa2 = new Funcionario();
            Funcionario media = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media.salario = (pessoa1.salario + pessoa2.salario) / 2;

            Console.WriteLine("Salário médio= " + media.salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
