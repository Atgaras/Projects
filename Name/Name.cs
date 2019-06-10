using System;

namespace NameCl
{
    public class Human
    {
        public string Name {get; set;}
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; private set; }
        public int GetAge()
        {
            return (DateTime.Now.Year - DateOfBirth.Year);
        }
        public Human(string name, string surname, DateTime birth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = birth;
        }
    }
}
