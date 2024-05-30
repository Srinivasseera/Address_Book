using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Contacts
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public Contacts(string firstname, string lastname, string Address, string city, string state, string zip, string phonenumber, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phonenumber = phonenumber;
            this.email = email;
        }
        public void Display()
        {

            Console.WriteLine($"{firstname}\n{lastname}\n{Address}\n{city}\n{state}\n{zip}\n{phonenumber}\n{email}");

        }


    }

}
