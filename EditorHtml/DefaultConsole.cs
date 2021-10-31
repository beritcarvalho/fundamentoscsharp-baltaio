using System;

namespace EditorHtml
{
    public static class DefaultConsole
    {
        public static void Clear()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}