using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n - кол-во студентов:");
            int n;
            while (! int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Число студентов должно быть больше нуля");
            }
            double[] StudHei = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите рост студента {i + 1} (в см:)");
                while (! double.TryParse(Console.ReadLine(), out StudHei[i]) || StudHei[i] <= 0) 
                { 
                    Console.WriteLine("Рост должен быть больше нуля"); 
                }
            }
            double AvgHei = CalHei(StudHei);
            Console.WriteLine($"Средний рост студентов в группе: {AvgHei:F2} см");
            double CalHei(double[] Hei)
            {
                double sum = 0;
                foreach (double d in StudHei) { 
                sum += d;
                }
                return sum / StudHei.Length;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
