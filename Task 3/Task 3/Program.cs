using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Пожалуйста, введите двузначное число.");
                return;
            }

            int tens = number / 10;
            int units = number % 10;
            int sum = tens + units;
            int product = tens * units;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
            Console.ReadKey();
        }
    }
}
