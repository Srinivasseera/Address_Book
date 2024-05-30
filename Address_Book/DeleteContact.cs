using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class DeleteContact
    {
        public void Deletecontact(ArrayList list)
        {
            Console.WriteLine("enter the first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter the last name");
            string lastname = Console.ReadLine();
            if (firstname.Length == 0 && lastname.Length == 0)
            {
                Console.WriteLine("enter the correct input");
            }
            else if (lastname.Length > 0 && firstname.Length > 0)
            {
                foreach (Contacts item in list)
                {
                    list.Remove(item);
                    Console.WriteLine("sucessfully deleted");
                    return;
                }

            }
        }
    }
}
