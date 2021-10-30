using System;
using System.Threading;

namespace StopWatch
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
            Console.WriteLine("Conta tempo\n\nC = Crescente\nD = Decrecente\n0 = Sair");
            string wayToCount = Console.ReadLine().ToLower();

            if (wayToCount != "d" && wayToCount != "c" && wayToCount != "0")
                Menu();

            if (wayToCount == "0")
                System.Environment.Exit(0);

            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos" +
            "\nM = Minuto => 10m => 10 minutos" +
            "\n0 = Sair\n");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();

            if (data.Length == 1)
                Menu();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            PreStart();
            Start(time * multiplier, wayToCount);

        }


        static void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go...");
            Thread.Sleep(2500);
        }


        static void Start(int time, string wayToCount)
        {
            if (wayToCount == "c")
            {
                int currentTime = 0;

                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
            }
            else
            {
                int currentTime = time;
                time = 0;

                while (currentTime != time)
                {
                    Console.Clear();
                    Console.WriteLine(currentTime);
                    currentTime--;
                    Thread.Sleep(1000);
                }
            }

            Console.Clear();
            Console.WriteLine("StopWacth Finalizado");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
