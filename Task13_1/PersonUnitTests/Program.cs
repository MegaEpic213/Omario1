using MELibrary;
using NUnit.Framework;
using System;

namespace MELibrary.UnitTests
{
    [TestFixture]
    public class PersonUnitTests
    {
        [Test]
        public void ConstructorTests()
        {
            var john = CreateTestPerson();
            Assert.That(john.Name, Is.EqualTo("John"));
            Assert.That(john.Surname, Is.EqualTo("Doe"));
            Assert.That(john.Birthday, Is.EqualTo(new DateTime(2004, 7, 15)));
            Assert.That(john.Gender, Is.EqualTo(PersonGender.Male));
        }

        [Test]
        public void GetInfoTests()
        {
            var john = CreateTestPerson();
            var info = john.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("John Doe"));
        }

        private Person CreateTestPerson()
        {
            return new Person("John", "Doe", "15.07.2004", PersonGender.Male);
        }
    }

    [TestFixture]
    public class ContactUnitTests
    {
        [Test]
        public void ConstructorTests()
        {
            var contact = CreateTestContact();

            Assert.That(contact.Name, Is.EqualTo("Иван"));
            Assert.That(contact.Surname, Is.EqualTo("Иванов"));
            Assert.That(contact.ContactId, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void GetInfoTests()
        {
            var contact = CreateTestContact();
            var info = contact.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
        }

        private Contact CreateTestContact()
        {
            return new Contact(
                name: "Иван",
                surname: "Иванов",
                address: "ул. Пушкина, д.10",
                group: ContactGroup.Friends,
                phone: "+79001234567",
                notes: "Лучший друг");
        }
    }
}