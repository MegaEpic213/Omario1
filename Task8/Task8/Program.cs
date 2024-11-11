using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргемента функции: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey();
        }
        static double MyFunction (double x)
            {
            if (x > 0)
                return 1;
            else if (x < 1)
                return -1;
            else if (x != 0)
                return 0;
                    return x;
            }
        }
    }
