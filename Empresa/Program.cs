using Empresa.Entitis;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<Funcionario> list = new List<Funcionario>();

        Console.WriteLine("Quantos funcionarios: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            char terceiro;

            Console.WriteLine("Funcionario terceiro(s/n)");
            terceiro = char.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario {i+1}#");
            string nome;
            int horas;
            double valorHora;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Hora: ");
            horas = int.Parse(Console.ReadLine());

            Console.Write("valorHora: ");
            valorHora = double.Parse(Console.ReadLine());

            bool bulean = false;
            switch (terceiro)
            {
                case 's':
                    bulean = true;
                break;

                case 'S':
                    bulean = true;
                break;

                case 'n':
                    bulean = false;
                break;

                case 'N':
                    bulean = false;
                break;

                default:
                    Console.WriteLine("Funcionario não terceiro!");
                break;
            }

            if (bulean == true)
            {
                double adicional;

                Console.Write("Adicional: ");
                adicional = double.Parse(Console.ReadLine());

                list.Add(new Terceiro(nome, horas, valorHora, adicional));
            }else {
                list.Add(new Funcionario(nome, horas, valorHora));
            }
        }

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}