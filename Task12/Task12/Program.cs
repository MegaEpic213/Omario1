using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Запросить у пользователя m и n
        Console.Write("Введите натуральное число m (от 5 до 20): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите натуральное число n (от 5 до 20): ");
        int n = int.Parse(Console.ReadLine());

        // Инициализация и заполнение массива случайными числами
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rand.Next(0, 100);
            }
        }

        // Вывод массива на консоль
        PrintArray(array);

        // Запросить у пользователя число для поиска в массиве
        Console.Write("Введите число для поиска в массиве: ");
        int searchNumber = int.Parse(Console.ReadLine());

        // Проверка наличия числа в массиве и вывод результата
        var result = FindNumber(array, searchNumber);
        if (result != null)
        {
            Console.WriteLine($"Число найдено на позиции: строка {result.Item1}, столбец {result.Item2}");
        }
        else
        {
            Console.WriteLine("Число не найдено в массиве.");
        }

        // Поиск и вывод максимальных элементов в каждой строке
        int[] maxElements = FindMaxInRows(array);
        for (int i = 0; i < maxElements.Length; i++)
        {
            Console.WriteLine($"Максимальный элемент в строке {i}: {maxElements[i]}");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static Tuple<int, int> FindNumber(int[,] array, int number)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == number)
                {
                    return Tuple.Create(i, j);
                }
            }
        }
        return null;
    }

    static int[] FindMaxInRows(int[,] array)
    {
        int[] maxElements = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int max = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
            maxElements[i] = max;
        }
        return maxElements;
    }
}
