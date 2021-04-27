using System;
namespace ExModulo9.Entities
{
    public class Client
    {
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return "Client: "
            + Name
            +"("
            + BirthDate
            +") - "
            + Email;
        }
    }
}