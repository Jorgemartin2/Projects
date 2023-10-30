using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            
            Console.Write("Primeiro valor: ");
            float primaryValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondaryValue = float.Parse(Console.ReadLine());

            float result = primaryValue + secondaryValue;

            Console.WriteLine($"O resultado da soma {primaryValue} + {secondaryValue} = {result}");
            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primaryValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondaryValue = float.Parse(Console.ReadLine());

            float result = primaryValue - secondaryValue;

            Console.WriteLine($"O resultado da subtração {primaryValue} - {secondaryValue} = {result}");
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primaryValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondaryValue = float.Parse(Console.ReadLine());

            float result = primaryValue / secondaryValue;

            Console.WriteLine($"O resultado da divisão {primaryValue} / {secondaryValue} = {result}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primaryValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondaryValue = float.Parse(Console.ReadLine());

            float result = primaryValue * secondaryValue;

            Console.WriteLine($"O resultado da multiplicação {primaryValue} x {secondaryValue} = {result}");
            Console.ReadKey();
            Menu();
        }
    }
}