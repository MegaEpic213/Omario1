using System;

namespace HRLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly DateTime Birthday;
        public readonly PersonGender Gender;

        public int Age => DateTime.Now.Year - Birthday.Year;

        public Person(string name, string surname, string birthday, PersonGender gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;

            if (!DateTime.TryParse(birthday, out Birthday))
                throw new ArgumentException("Неверный формат даты рождения");
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Name} {Surname}";

            string gender;
            if (Gender == PersonGender.Male)
                gender = "мужской";
            else
                gender = "женский";

            info[1] = $"Дата рождения: {Birthday:d}. Пол: {gender}. Возраст: {Age}.";
            return info;
        }
    }
}

namespace HRLibrary
{
    public enum PersonGender
    {
        Male,
        Female
    }
}