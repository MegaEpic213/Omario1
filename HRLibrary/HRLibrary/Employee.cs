using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public abstract class Employee : Person
    {
        public string Department {  get; set; }
        public string Position { get; set; }

        public Employee(string name, string surname, string birthday, PersonGender gedner) : base(name,surname, birthday, gedner) { }

        public abstract double CalculateSalary();

    }
}
