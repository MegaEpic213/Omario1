using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Posit(5, -3));
            Console.WriteLine(Posit(-1, -2));
            Console.WriteLine(Posit(0, 4));
            Console.WriteLine(Posit(-7, 0));
        }
        static void Posit(int m, int n) 
        {
        int resuilt = (m > 0) ? m : (n>0) ? n : 0;
            Console.WriteLine(resuilt);
        }
    }
}
