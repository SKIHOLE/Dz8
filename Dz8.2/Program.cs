using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dz8._2
{
    enum Colors
    {
        Black = 0,
        Blue = 1,
        Green = 2,
        Cyan = 3,
        Red = 4,
        Magenta = 5,
        Yellow = 6,
        White = 7
    }

    static class Printer
    {
        public static void Print(string text, int color)
        {
            if (color >= 0 && color <= 7)
            {
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Недійсний код кольору.");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть рядок:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Виберіть код кольору:");
            for (int i = 0; i < (int)Colors.White+1; i++)
            {
                Colors consoleColor = (Colors)i;
                Console.WriteLine($"{(int)consoleColor} = {consoleColor}");
            }        
            if (int.TryParse(Console.ReadLine(), out int colorCode))
            {
                Printer.Print(inputString, colorCode);
            }
            else
            {
                Console.WriteLine("Недійсний код кольору.");
            }
        }
    }
}