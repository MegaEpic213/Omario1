using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Солнечный зайчик взломал потолок");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Солнечный зайчик взломал потолок.\n" +
                              "Закатился камешек на гору.\n" +
                              "Пряная косточка свежего горя\n" +
                              "Верно и яростно канула\n" +
                              "В янтарную лету заслуженного долголетия.\n" +
                              "Солнечный зайчик взорвал потолок.\n" +
                              "Кончился почерк. Угасли дожди.\n" +
                              "Стихло безмолвие.\n" +
                              "Родина настала.\n");

            Console.ForegroundColor = originalColor;
            Console.ReadKey();
        }
    }
}

