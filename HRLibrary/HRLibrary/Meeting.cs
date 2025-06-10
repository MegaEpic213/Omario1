using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Meeting : Event
    {
        public string WithWhom { get; set; } 
        public string Topic { get; set; }    

        public Meeting(DateTime eventDateTime, string location,
                      string withWhom, string topic)
            : base(eventDateTime, location)
        {
            WithWhom = withWhom;
            Topic = topic;
        }

        public override void Remind()
        {
            base.Remind();
            Console.WriteLine($"Встреча с {WithWhom}");
            Console.WriteLine($"Тема: {Topic}");
            Console.WriteLine($"Подготовьтесь к встрече!\n");
        }
    }
}
