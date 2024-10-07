using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра:");
            var a = double.Parse(Console.ReadLine());
            var x = 12 * a;
            var s = 2 * Math.Pow(a, 2) * Math.Sqrt(3);
            var v = Math.Sqrt(Math.Pow(a, 3)) / 3 * Math.Sqrt(2);
            Console.WriteLine("Объём октаэдра: " + v);
            Console.WriteLine("Площадь поверхности: " + s);

            Console.ReadKey();
        }
    }
}