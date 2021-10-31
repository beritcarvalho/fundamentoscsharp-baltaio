using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            DefaultConsole.Clear();

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScrean(30, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScrean(int columns, int lines)
        {
            Columns(columns);
            Lines(columns, lines);
            Columns(columns);
        }

        public static void Columns(int amount)
        {
            Console.Write("+");
            for (int i = 0; i <= amount; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Lines(int columns, int lines)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= columns; j++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Visualiar");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Sair");
                    System.Environment.Exit(0); break;
                case 1:
                    Console.WriteLine("Novo Arquivo");
                    Editor.Show(); break;
                case 2:
                    Console.WriteLine("Visualiar");
                    Viewer.Show(); break;
                default:
                    Show(); break;
            }
        }
    }
}
