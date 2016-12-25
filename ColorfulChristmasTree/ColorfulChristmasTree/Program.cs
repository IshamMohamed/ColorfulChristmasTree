using System;

namespace ColorfulChristmasTree
{
    class Program
    {
        // Adjust the below - Play with them
        const int HEIGHT = 5;
        const int SEGMENTS = 4;

        static void Main(string[] args)
        {
            // Blink lights for each key press unless Esc key. 
            do
            {
                PrintTree();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void PrintTree()
        {
            Console.Clear();
            Random foreColor = new Random();
            int start = 2 * HEIGHT + 2 * SEGMENTS - 3;

            for (int i = 1; i <= SEGMENTS; i++)
            {
                for (int line = 1; line <= HEIGHT; line++)
                {
                    string initiator = "";
                    for (int j = 1; j <= 2 * line + 2 * i - 3; j++)
                    {
                        initiator += "*";
                    }
                    for (int space = 0; space <= start - (HEIGHT + line + i); space++)
                    {
                        initiator = " " + initiator;
                    }
                    Console.ForegroundColor = (ConsoleColor)foreColor.Next(7, 14); // Because these are light colors
                    Console.WriteLine(initiator);
                }
            }
        }
    }
}
