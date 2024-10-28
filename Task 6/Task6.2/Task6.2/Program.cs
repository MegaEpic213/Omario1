using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s "информатика";
            Console.WriteLine($"Из слова \"{s}\" получили");

            var word1 = s
                .Remove(0, 2)
            .Remove(3, 4)
            .Remove(1, 4);
            word1 += s
                .Remove(1, 2)
                .Remove(1, 1)
                .Remove(4);
            var word2 = s
                .Remove(0, 9)
                .Remove(1, 1);
            word2 += s
                .Remove(0, 3)
                .Remove(4);

            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.ReadKey();
        }
    }
}
