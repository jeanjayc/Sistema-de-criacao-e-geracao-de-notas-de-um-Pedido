using System;
namespace ExModulo9.Entities
{
    public class Client
    {
        public Client(int id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public int Id{ get; set;}
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