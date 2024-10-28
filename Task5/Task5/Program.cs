using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = (Math.Sqrt(6) + 6)/2 + (Math.Sqrt(13) + 13) / 5 + (Math.Sqrt(21) + 21) / 3;
            Console.Out.WriteLine(x.ToString("#.000"));
            Console.ReadKey();
        }
    }
}