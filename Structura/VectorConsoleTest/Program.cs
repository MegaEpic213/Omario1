using System;
using VectorStruct;

namespace VectorConsoleTest
{
    class Program
    {
        static void Main()
        {
            var v1 = new Vector3D(1, 2, 3);
            var v2 = new Vector3D(4, 5, 6);

            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"Длина v1: {v1.Length}");
            Console.WriteLine($"Сумма: {v1 + v2}");
            Console.WriteLine($"Разность: {v1 - v2}");
            Console.WriteLine($"Умножение на 2: {v1 * 2}");
            Console.WriteLine($"Скалярное произведение: {v1 * v2}");
            Console.WriteLine($"Векторное произведение: {v1 ^ v2}");
            Console.ReadLine();
        }
      
    }
}