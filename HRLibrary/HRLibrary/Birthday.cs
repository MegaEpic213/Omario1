using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Birthday : Event
    {
        public string Celebrant { get; set; }
        public int BirthYear { get; set; }
        public int Age => DateTime.Now.Year - BirthYear;

        public Birthday(DateTime eventDateTime, string location,
                       string celebrant, int birthYear)
            : base(eventDateTime, location)
        {
            Celebrant = celebrant;
            BirthYear = birthYear;
        }

        public override void Remind()
        {
            base.Remind();
            Console.WriteLine($"День рождения {Celebrant}!");
            Console.WriteLine($"Будет {Age} лет. Год рождения: {BirthYear}");
            Console.WriteLine($"Не забудьте поздравить!\n");
        }
    }
}
