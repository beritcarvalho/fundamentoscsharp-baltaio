using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            var resultado = valor1 + valor2;

            Console.WriteLine($"O Resultado da soma é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());

            var resultado = valor1 - valor2;

            Console.WriteLine($"O Resultado da subtração é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Mulplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());

            var resultado = valor1 * valor2;

            Console.WriteLine($"O Resultado da multiplicação é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());

            var resultado = valor1 / valor2;

            Console.WriteLine($"O Resultado da divisão é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção: ");

            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Mulplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                    Sair();
                    break;

                default:
                    Menu();
                    break;
            }

        }

        static void Sair()
        {
            Console.WriteLine("Obrigado :)");
            System.Environment.Exit(0);
        }


    }
}
