using NUnit.Framework;
using System;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class PersonUnitTests
    {

        [Test]
        public void PersonConstructorTest()
        {
            var person = CreateTestPerson();

            Assert.That(person.Name, Is.EqualTo("John"));
            Assert.That(person.Surname, Is.EqualTo("Smith"));
            Assert.That(person.Birthday.ToString("dd.MM.yyyy"), Is.EqualTo("15.07.2003"));
            Assert.That(person.Gender, Is.EqualTo(PersonGender.Male));
            Assert.That(person.Age, Is.EqualTo(CalculateExpectedAge(new DateTime(2003, 07, 15))));
        }

        [Test]
        public void PersonGetInfoTest()
        {
            var person = CreateTestPerson();
            var info = person.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("John Smith"));

            string expectedInfo = $"Дата рождения: 15.07.2003. Пол: Мужской. Возраст: {CalculateExpectedAge(new DateTime(2003, 07, 15))}.";
            Assert.That(info[1], Is.EqualTo(expectedInfo));
        }

        [Test]
        public void ContactConstructorTest()
        {
            var contact = CreateTestContact();

            Assert.That(contact.Name, Is.EqualTo("Anna"));
            Assert.That(contact.Surname, Is.EqualTo("Johnson"));
            Assert.That(contact.Address, Is.EqualTo("ул. Центральная, 1"));
            Assert.That(contact.Group, Is.EqualTo(ContactGroup.Friends));
            Assert.That(contact.Phone, Is.EqualTo("+1234567890"));
            Assert.That(contact.Notes, Is.EqualTo("Лучшая подруга"));
            Assert.That(contact.Id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void ContactGetInfoTest()
        {
            var contact = CreateTestContact();
            var info = contact.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Anna Johnson"));
            Assert.That(info[1], Is.EqualTo("Адрес: ул. Центральная, 1. Телефон: +1234567890. Группа: Друзья."));
            Assert.That(info[2], Is.EqualTo("Заметки: Лучшая подруга"));
        }

        [Test]
        public void ContactNullParametersTest()
        {
            Assert.Throws<ArgumentNullException>(() =>
                new Contact(null, "Johnson", "ул. Центральная, 1",
                          ContactGroup.Friends, "+1234567890", "Лучшая подруга"));

            Assert.Throws<ArgumentNullException>(() =>
                new Contact("Anna", null, "ул. Центральная, 1",
                          ContactGroup.Friends, "+1234567890", "Лучшая подруга"));
        }

        private Person CreateTestPerson()
        {
            return new Person("John", "Smith", "15.07.2003", PersonGender.Male);
        }

        private Contact CreateTestContact()
        {
            return new Contact("Anna", "Johnson", "ул. Центральная, 1",
                              ContactGroup.Friends, "+1234567890", "Лучшая подруга");
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