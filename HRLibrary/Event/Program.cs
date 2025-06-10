using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event1
{
    class Program
    {
        static void Main(string[] args)
        {
            Event[] events = new Event[]
            {
                new Birthday(new DateTime(2023, 12, 15, 18, 0, 0),
                    "Кафе 'Уют'", "Иван Иванов", 1990),
                new Meeting(new DateTime(2023, 12, 16, 10, 30, 0),
                    "Офис, каб. 305", "Алексей Петров", "Обсуждение проекта"),
                new Birthday(new DateTime(2023, 12, 20, 19, 0, 0),
                    "Дома", "Мария Сидорова", 1985)
            };

            Console.WriteLine("НАПОМИНАНИЯ:\n");
            foreach (var ev in events)
            {
                ev.Remind();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}