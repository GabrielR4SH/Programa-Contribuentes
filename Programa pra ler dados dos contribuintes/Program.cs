using System;
using System.Globalization;
using System.Collections.Generic;
using Programa_pra_ler_dados_dos_contribuintes.Entities;

namespace Programa_pra_ler_dados_dos_contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Anual income: ");
                double Income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' )
                {
                    Console.WriteLine("Health expenditures: ");
                    double Healthexpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Indivual(Name, Income, Healthexpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(Name, Income, numberOfEmployees));
                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + " : $ " + tax.ToString("F2",CultureInfo.InvariantCulture));

                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
