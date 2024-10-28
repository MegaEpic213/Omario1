using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            var x = double.Parse(Console.ReadLine());
            var y = Math.Sqrt(x + 1/Math.Sqrt(Math.Pow(x,2)+4));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}