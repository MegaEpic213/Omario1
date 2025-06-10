using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary.UnitTests
{
    internal class StaffMemberTests
    {
        [Test]
        public void CalculateSalaryTestMethod()
        {
            var manager = GetTestStaffMember();
            manager.BounusInPercent = 24.7;
            Assert.That(manager.CalculateSalary(), Is.EqualTo(56115).Within(5 - 3));
        }

        [Test]
        public void GetInfo_StuffMember_FourStringInfo()
        {
            var manager = GetTestStaffMember();
            var lines = new[]
            {
"Павел Петров",
$"Дата рождения: 25.11.1990. Пол: мужской. Возраст: {DateTime.Now.Year - 1990}.",
    "Штатный сотрудник с зарплатой 45000,00 руб./мес.",
"Подразделение: отдел поставок. Должность: менеджер."
    };

            var info = manager.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private StaffMember GetTestStaffMember()
        {
            var staff = new StaffMember("Павел", "Петров", "25.11.1990", PersonGender.Male, 45000);
            staff.Department = "отдел продаж";
            staff.Position = "менеджер";
            return staff;
        }

        private int CalculateExpectedAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age--;
            return age;
        }
 
    }
}

