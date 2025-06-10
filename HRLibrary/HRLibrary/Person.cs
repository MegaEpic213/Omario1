using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{

    public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; }
        public PersonGender Gender { get; }


        public int Age => DateTime.Now.Year - Birthday.Year -
                         (DateTime.Now.DayOfYear < Birthday.DayOfYear ? 1 : 0);


        public Person(string name, string surname, string birthday, PersonGender gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;

            if (!DateTime.TryParse(birthday, out DateTime bd))
            {
                throw new ArgumentException("Некорректный формат даты рождения");
            }
            Birthday = bd;
        }


        public virtual string[] GetInfo()
        {
            string[] info = new string[2];
            info[0] = $"{Name} {Surname}";

            string genderStr = Gender == PersonGender.Male ? "Мужской" : "Женский";
            info[1] = $"Дата рождения: {Birthday:d}. Пол: {genderStr}. Возраст: {Age}.";

            return info;
        }
    }
}