using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(System.Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine(@"  Deseja salvar o arquivo?
            1 - Sim
            2 - Não");
            short option = short.Parse(Console.ReadLine());
            ChooseSaveFile(option);

            if (option == 1)
            {
                Save(file);
                Menu.Show();
            }
            else
                Viewer.ReadEditor(file.ToString());

        }

        public static void ChooseSaveFile(short option)
        {
            while (option != 1 && option != 2)
            {
                Console.Clear();
                Console.WriteLine("------------");
                Console.WriteLine(@"Deseja salvar o arquivo?
                1 - Sim
                2 - Não");
                option = short.Parse(Console.ReadLine());
            }
        }

        static void Save(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Qual o diretório para salvar o arquivo?");
            var path = Console.ReadLine();

            char barra = char.Parse(path.Substring(path.Length - 1, 1));
            if (barra != '\\')
                path += "\\";

            Console.WriteLine("Salvar como");
            path += Console.ReadLine();

            path += ".txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadKey();

            Menu.Show();
        }


    }
}