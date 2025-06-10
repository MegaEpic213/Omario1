using NUnit.Framework;
using System;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class HRLibraryTests
    {
        [Test]
        public void PersonConstructorTest()
        {
            var john = new Person("John", "Smith", "15.07.2003", PersonGender.Male);

            Assert.That(john.Name, Is.EqualTo("John"));
            Assert.That(john.Surname, Is.EqualTo("Smith"));
            Assert.That(john.Birthday.ToShortDateString(), Is.EqualTo("15.07.2003"));
            Assert.That(john.Gender, Is.EqualTo(PersonGender.Male));
            Assert.That(john.Age, Is.EqualTo(DateTime.Now.Year - 2003));
        }

        [Test]
        public void PersonGetInfoTest()
        {
            var john = new Person("John", "Smith", "15.07.2003", PersonGender.Male);
            var info = john.GetInfo().Split(", ");

            Assert.That(info.Length, Is.EqualTo(5));
            Assert.That(info[0], Is.EqualTo("Имя: John"));
            Assert.That(info[1], Is.EqualTo("Фамилия: Smith"));
            Assert.That(info[2], Is.EqualTo("Пол: Male"));
            Assert.That(info[3], Is.EqualTo("Возраст: " + (DateTime.Now.Year - 2003)));
            Assert.That(info[4], Is.EqualTo("Дата рождения: 15.07.2003"));
        }

        [Test]
        public void ContactConstructorTest()
        {
            var contact = new Contact("Alice", "Brown", "123 Main St", ContactGroup.Friends, "+123456789", "Close friend");

            Assert.That(contact.Name, Is.EqualTo("Alice"));
            Assert.That(contact.Surname, Is.EqualTo("Brown"));
            Assert.That(contact.Address, Is.EqualTo("123 Main St"));
            Assert.That(contact.Group, Is.EqualTo(ContactGroup.Friends));
            Assert.That(contact.Phone, Is.EqualTo("+123456789"));
            Assert.That(contact.Notes, Is.EqualTo("Close friend"));
        }

        [Test]
        public void ContactGetInfoTest()
        {
            var contact = new Contact("Alice", "Brown", "123 Main St", ContactGroup.Friends, "+123456789", "Close friend");
            var info = contact.GetInfo().Split(", ");

            Assert.That(info.Length, Is.EqualTo(6));
            Assert.That(info[0], Is.EqualTo("Имя: Alice"));
            Assert.That(info[1], Is.EqualTo("Фамилия: Brown"));
            Assert.That(info[2], Is.EqualTo("Адрес: 123 Main St"));
            Assert.That(info[3], Is.EqualTo("Группа: Friends"));
            Assert.That(info[4], Is.EqualTo("Телефон: +123456789"));
            Assert.That(info[5], Is.EqualTo("Заметки: Close friend"));
        }
    }
}
