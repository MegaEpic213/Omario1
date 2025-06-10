using System;

namespace HRLibrary
{
    public enum ContactGroup
    {
        Family,     
        Friends,   
        Acquaintances, 
        Work,      
        None      
    }

    public class Contact
    {
   
        public string Name { get; }
        public string Surname { get; }
        public string Address { get; }
        public ContactGroup Group { get; }
        public string Phone { get; }
        public string Notes { get; }


        public Guid Id { get; } = Guid.NewGuid();


        public Contact(string name, string surname, string address,
                      ContactGroup group, string phone, string notes)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Group = group;
            Phone = phone;
            Notes = notes;
        }

   
        public virtual string[] GetInfo()
        {
            string[] info = new string[3];
            info[0] = $"{Name} {Surname}";
            info[1] = $"Адрес: {Address}. Телефон: {Phone}. Группа: {GetGroupName(Group)}.";
            info[2] = $"Заметки: {Notes}";
            return info;
        }

        private string GetGroupName(ContactGroup group)
        {
            switch (group)
            {
                case ContactGroup.Family:
                    return "Семья";
                case ContactGroup.Friends:
                    return "Друзья";
                case ContactGroup.Acquaintances:
                    return "Знакомые";
                case ContactGroup.Work:
                    return "Работа";
                case ContactGroup.None:
                    return "Без группы";
                default:
                    return "Неизвестно";
            }
        }
    }
}