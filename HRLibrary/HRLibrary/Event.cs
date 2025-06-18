using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Event
    {
        public DateTime EventDateTime { get; set; }
        public string Location { get; set; }

        public Event(DateTime eventDateTime, string location)
        {
            EventDateTime = eventDateTime;
            Location = location;
        }

        public virtual void Remind()
        {
            Console.WriteLine($"Событие: {EventDateTime:g} в {Location}");
        }
    }
}
