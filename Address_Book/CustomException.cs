using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class CustomException : ApplicationException
    {
        public CustomException()
        {
            Console.WriteLine("Custom Exception");
        }
        public class InvalidFirstname : CustomException
        {
            public InvalidFirstname()
            {
                Console.WriteLine("Enter the correct first name");
            }
        }
        public class InvalidLastname : CustomException
        {
            public InvalidLastname()
            {
                Console.WriteLine("Enter the correct Last name");
            }
        }
        public class InvalidAddress : CustomException
        {
            public InvalidAddress()
            {
                Console.WriteLine("Enter the Valid Address");
            }
        }
        public class InvalidCity : CustomException
        {
            public InvalidCity()
            {
                Console.WriteLine("Enter the Valid City Name");
            }
        }
        public class InvalidState : CustomException
        {
            public InvalidState()
            {
                Console.WriteLine("Enter the Valid State Name");
            }
        }
        public class InvalidZip : CustomException
        {
            public InvalidZip()
            {
                Console.WriteLine("Enter the valid Zip");
            }
        }
        public class InvalidPhone : CustomException
        {
            public InvalidPhone()
            {
                Console.WriteLine("Enter the correct Phone Number");
            }
        }
        public class InvalidEmail : CustomException
        {
            public InvalidEmail()
            {
                Console.WriteLine("Enter the Correct Email");
            }
        }
    }
}
