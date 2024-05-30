using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Address_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            ArrayList list = new ArrayList();
            AddDetails a = new AddDetails();
            a.Adddetail(list);
        }
    }
}
