using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Funcionario1 = new Funcionario();
            Funcionario Funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            Funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            Funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Funcionario1.Salario + Funcionario2.Salario) / 2.0;

            Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
