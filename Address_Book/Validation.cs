using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Validation
    {
        private string pname { get; set; } = "[A-Z]{1}[a-z]{3,9}";
        private string address_name { get; set; } = @"^[A-Za-z0-9\s.,#-]+$";
        private string Zip { get; set; } = @"^\d{6}$";
        private string number { get; set; } = @"^[0-9]{10}$";
        private string Email_Input { get; set; } = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

        public bool IsName(string name)
        {
            if (Regex.IsMatch(name, pname)) return true;
            return false;
        }
        public bool IsLast(string Last)
        {
            if (Regex.IsMatch(Last, pname)) return true;
            return false;
        }
        public bool Isaddress(string Add)
        {
            if (Regex.IsMatch(Add, address_name)) return true;
            return false;
        }
        public bool IsCity(String City)
        {
            if (Regex.IsMatch(City, pname)) return true;
            return false;
        }
        public bool IsState(String State)
        {
            if (Regex.IsMatch(State, pname)) return true;
            return false;
        }
        public bool IsZip(String zip)
        {
            if (Regex.IsMatch(zip, Zip)) return true;
            return false;
        }
        public bool Isphonenumber(String Phonenumber)
        {
            if (Regex.IsMatch(Phonenumber, number)) return true;
            return false;
        }
        public bool IsEmail(string email)
        {
            if (Regex.IsMatch(email, Email_Input)) return true;
            return false;
        }
    }
}
