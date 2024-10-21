using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском языке");

            var text = Console.ReadLine();

            Console.WriteLine("На языке Leet");
            Console.WriteLine(LeetTranslate(text));

            Console.ReadKey();
        }
        static string LeetTranslate(string s)
        {
            return s
                .ToUpper()
                .Replace("A", "4")
                .Replace("B", "8")
                .Replace("C", "(")
                .Replace("D", "|)")
                .Replace("E", "3")
                .Replace("F", "|=")
                .Replace("G", "6")
                .Replace("H", "|-|")
                .Replace("I", "!")
                .Replace("J", ")")
                .Replace("K", "|<")
                .Replace("L", "1")
                .Replace("M", @"|\/|")
                .Replace("N", @"|\|")
                .Replace("O", "0")
                .Replace("P", "|>")
                .Replace("Q", "9")
                .Replace("R", "|2")
                .Replace("S", "5")
                .Replace("T", "7")
                .Replace("U", "|_|")
                .Replace("V", @"\/")
                .Replace("W", @"\/\/")
                .Replace("X", "><")
                .Replace("Y", "'/")
                .Replace("Z", "2")
                .Replace("a", "4")
                .Replace("b", "8")
                .Replace("c", "(")
                .Replace("d", "|)")
                .Replace("e", "3")
                .Replace("f", "|=")
                .Replace("g", "6")
                .Replace("h", "|-|")
                .Replace("i", "!")
                .Replace("j", ")")
                .Replace("k", "|<")
                .Replace("l", "1")
                .Replace("m", @"|\/|")
                .Replace("n", @"|\|")
                .Replace("o", "0")
                .Replace("p", "|>")
                .Replace("q", "9")
                .Replace("r", "|2")
                .Replace("s", "5")
                .Replace("t", "7")
                .Replace("u", "|_|")
                .Replace("v", @"\/")
                .Replace("w", @"\/\/")
                .Replace("x", "><")
                .Replace("y", "'/")
                .Replace("z", "2");
        }
    }
}