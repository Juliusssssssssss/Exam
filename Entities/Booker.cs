using System;

namespace Entities
{
    public class Booker
    {
        public Booker(int id, string name, string mail, int phonenumber)
        {
            this.Id = id;
            this.Name = name;
            this.Mail = mail;
            this.Phonenumber = phonenumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Phonenumber { get; set; }

    }
}
