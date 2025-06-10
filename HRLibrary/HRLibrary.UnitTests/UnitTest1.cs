namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class PersonUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var john = CreateTestPerson();
            Assert.That(john.Name, Is.EqualTo("John"));
            Assert.That(john.Surname, Is.EqualTo("Smith"));
            Assert.That(john.Birthday.ToString("dd.MM.yyyy"), Is.EqualTo("15.07.2003"));
            Assert.That(john.Gender, Is.EqualTo(PersonGender.Male));
            Assert.That(john.Age, Is.EqualTo(DateTime.Now.Year - 2003));
        }

        [Test]
        public void GetInfoTest()
        {
            var john = CreateTestPerson();
            var info = john.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("John Smith"));
            Assert.That($"Дата рождения: 15.07.2003. Пол: мужской. Возраст: {DateTime.Now.Year - 2003}.",
                Is.EqualTo(info[1]));
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


        private Person CreateTestPerson()
        {
            return new Person("John", "Smith", "15.07.2003", PersonGender.Male);
        }

        private Contact CreateTestContact()
        {
            return new Contact("Anna", "Johnson", "ул. Центральная, 1",
                             ContactGroup.Friends, "+1234567890", "Лучшая подруга");
        }
    }
}