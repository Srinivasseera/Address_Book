using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class EditContact
    {
        public void EditDetail(ArrayList list)
        {
            Console.WriteLine("editing the contacts");
            Console.WriteLine("enter the first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter the last name");
            string lastname = Console.ReadLine();
            if (firstname.Length == 0 && lastname.Length == 0)
            {
                Console.WriteLine("enter the valid inputs");
            }
            else if (firstname.Length > 0 && lastname.Length > 0)
            {
                foreach (Contacts item in list)
                {
                    if (item.firstname == firstname && item.lastname == lastname)
                    {
                        Console.WriteLine("enter the 1 to edit first name");
                        Console.WriteLine("enter the 2 to edit last name");
                        Console.WriteLine("enter the 3 to edit address");
                        Console.WriteLine("enter the 4 to edit city");
                        Console.WriteLine("enter the 5 to edit state");
                        Console.WriteLine("enter the 6 to edit zip");
                        Console.WriteLine("enter the 7 to edit phonenumber");
                        Console.WriteLine("enter the 8 to edit email");
                        Console.WriteLine("enter the 9 to for exit");
                        Console.WriteLine("enter the choice");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("edit your first name");
                                string fname = Console.ReadLine();
                                item.firstname = fname;
                                break;
                            case 2:
                                Console.WriteLine("enter your last name");
                                string lname = Console.ReadLine();
                                item.lastname = lname;
                                break;
                            case 3:
                                Console.WriteLine("enter your address");
                                string add = Console.ReadLine();
                                item.Address = add;
                                break;
                            case 4:
                                Console.WriteLine("enter your city");
                                string ct = Console.ReadLine();
                                item.city = ct;
                                break;
                            case 5:
                                Console.WriteLine("enter your state");
                                string st = Console.ReadLine();
                                item.state = st;
                                break;
                            case 6:
                                Console.WriteLine("enter your zip");
                                string ZIP = Console.ReadLine();
                                item.zip = ZIP;
                                break;
                            case 7:
                                Console.WriteLine("enter your phonenumber");
                                string mobile = Console.ReadLine();
                                item.phonenumber = mobile;
                                break;
                            case 8:
                                Console.WriteLine("enter your email");
                                string EMAIL = Console.ReadLine();
                                item.email = EMAIL;
                                break;
                            case 9:
                                return;
                            default:
                                Console.WriteLine("enter correct number");
                                break;
                        }
                        item.Display();
                    }
                    else
                    {
                        Console.WriteLine("please enter the correct details");
                    }

                }

            }
        }

    }
}
