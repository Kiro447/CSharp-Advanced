using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode
{
    public static class Recap
    {
        public static void PrintTextWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void PrintText(this string text, ConsoleColor color)

        {
            Console.ForegroundColor=color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
