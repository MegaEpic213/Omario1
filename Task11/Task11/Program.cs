using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Запросить у пользователя первый член арифметической прогрессии и разность
            int a = GetUserInput("Введите первый член арифметической прогрессии (a):");
            int d = GetUserInput("Введите разность (d):");

            // Заполнить массив первыми десятью членами прогрессии
            int[] progression = GenerateArithmeticProgression(a, d, 10);

            // Вывести элементы массива на консоль через запятую
            PrintArray(progression);

            // Запросить у пользователя значение k для увеличения элементов массива
            int k = GetUserInput("Введите значение k для увеличения элементов массива:");

            // Увеличить элементы массива на k и вывести результат
            IncreaseElements(progression, k);
            PrintArray(progression);

            // Вычислить количество нечетных элементов массива и вывести на консоль
            int oddCount = CountOddElements(progression);
            Console.WriteLine($"Количество нечетных элементов: {oddCount}");

            // Запросить у пользователя натуральное число для возведения элементов в степень
            int power = GetUserInput("Введите натуральное число для возведения элементов массива в степень:");

            // Вывести элементы массива, возведенные в натуральную степень
            int[] poweredArray = PowerElements(progression, power);
            PrintArray(poweredArray);

            // Проверить, хочет ли пользователь продолжить работу с программой
            Console.WriteLine("Хотите продолжить? (да/нет)");
            string response = Console.ReadLine().ToLower();
            if (response != "да")
            {
                break;
            }
        }
    }

    static int GetUserInput(string message)
    {
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
    }

    static int[] GenerateArithmeticProgression(int firstElement, int difference, int length)
    {
        return Enumerable.Range(0, length).Select(i => firstElement + i * difference).ToArray();
    }

    // Метод для вывода элементов массива через запятую
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    // Метод для увеличения элементов массива на k
    static void IncreaseElements(int[] array, int k)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] += k;
        }
    }

    // Метод для подсчета количества нечетных элементов массива
    static int CountOddElements(int[] array)
    {
        return array.Count(item => item % 2 != 0);
    }

    // Метод для возведения элементов массива в натуральную степень
    static int[] PowerElements(int[] array, int power)
    {
        return array.Select(item => (int)Math.Pow(item, power)).ToArray();
    }
}
