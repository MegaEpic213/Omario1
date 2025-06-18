using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class StaffMember : Employee
    {
        public double Salary { get; set; }
        public double BounusInPercent { get; set; }

        public StaffMember(string name, string surname, string birthday, PersonGender gender, double salary)
            : base(name, surname, birthday, gender)
        {
            Salary = salary;
        }

        public override double CalculateSalary() => Math.Round(Salary * (1 + BounusInPercent / 100), 2);

        public override string[] GetInfo()
        {
            var info = new string[4];
            var personInfo = base.GetInfo();

            info[0] = personInfo[0];
            info[1] = personInfo[1];
            info[2] = $"Штатный сотрудник с зарплатой {Salary:F2} py6./мес.";
            info[3] = $"Подразделение: {Department}. Должность: {Position}.";

            return info;
        }
    }
}
