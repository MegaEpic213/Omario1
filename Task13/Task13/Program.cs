using System;

namespace Contactlibrary
{
    public class Contact
    {
        public string Name { get; set; }                
        public string Surname { get; set; }             
        public string Address { get; set; }             
        public ContactGroup Group { get; set; }         
        public Guid Id { get; }                         
        public string Phone { get; set; }               
        public string Notes { get; set; }              

        public Contact(string name, string surname, string address, ContactGroup group, string phone, string notes)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Group = group;
            Phone = phone;
            Notes = notes;
            Id = Guid.NewGuid();  
        }


        public virtual string[] GetInfo()
        {
            var info = new string[3];
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
                    return "семья";
                case ContactGroup.Friends:
                    return "друзья";
                case ContactGroup.Acquaintances:
                    return "знакомые";
                case ContactGroup.Work:
                    return "работа";
                default:
                    return "без группы";
            }
        }
    }
}