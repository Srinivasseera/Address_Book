using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static Address_Book.CustomException;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddDetails
    {

        public void Adddetail(ArrayList list)
        {

            Validation validation = new Validation();
            Console.WriteLine("enter the first name");
            string firstname = Console.ReadLine();

            if (!validation.IsName(firstname)) throw new InvalidFirstname();

            Console.WriteLine("enter the last name");
            string lastname = Console.ReadLine();
            if (!validation.IsName(lastname)) throw new InvalidLastname();

            Console.WriteLine("enter the address");
            string address = Console.ReadLine();
            if (!validation.IsName(address)) throw new InvalidAddress();

            Console.WriteLine("enter the city");
            string city = Console.ReadLine();

            if (!validation.IsCity(city)) throw new InvalidCity();

            Console.WriteLine("enter the state");
            string state = Console.ReadLine();

            if (!validation.IsState(state)) throw new InvalidState();

            Console.WriteLine("enter the zip");
            string zip = Console.ReadLine();
            if (!validation.IsZip(zip)) throw new InvalidZip();

            Console.WriteLine("enter the phonenumber");
            string phonenumber = Console.ReadLine();
            if (!validation.Isphonenumber(phonenumber)) throw new InvalidPhone();

            Console.WriteLine("enter the email");
            string email = Console.ReadLine();
            if (!validation.IsEmail(email)) throw new InvalidEmail();

            Contacts contacts = new Contacts(firstname, lastname, address, city, state, zip, phonenumber, email);
            list.Add(contacts);
            foreach (Contacts item in list)
            {
                item.Display();
            }

        }
    }

}





