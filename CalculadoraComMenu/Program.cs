using System;

namespace CalculadoraComMenu
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

            Console.WriteLine("0 - Qual operação Matemática deseja Realizar ? ");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");


            Console.WriteLine("*-----------------------*");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
            Console.ReadKey();

        }

        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Digite um valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine("Resultado da Soma é: " + resultado);
            //Console.WriteLine($"Resultado da Soma é: { resultado}");
            //Console.WriteLine($"Resultado da Soma é: {valor1 + valor2}");
            //Console.WriteLine("Resultado da Soma é: " + (valor1 + valor2));
            Console.ReadLine();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor: ");
            float subtrac1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float subtrac2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = subtrac1 - subtrac2;
            Console.WriteLine($"Resultado da Subtração é { resultado}"); // Utilizando interpolação de strings
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor: ");
            float div1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float div2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = div1 / div2;
            Console.WriteLine($"Resultado da Divisão é { resultado}"); // Utilizando interpolação de strings
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor: ");
            float mulit1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            float mulit2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = mulit1 * mulit1;
            Console.WriteLine($"Resultado da Multiplicação é { resultado}"); // Utilizando interpolação de strings
            Console.ReadKey();
            Menu();
        }

    }
}
