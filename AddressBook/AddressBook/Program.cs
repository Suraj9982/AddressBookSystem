using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK SYSTEM");
            bool flag = true;
            int option;
            Contact newcontact = new Contact();
            AddressBookList add = new AddressBookList();
            while (flag == true)
            {
                Console.WriteLine("CHOOSE OPTION\n1.Create Contact\n2.Add contact in addressbook\n3.Edit contact\n4.Delete Contact\n5.Add Unique Contact\n6.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("create contact in specific order:firstname,lastname,address,city,state,zip,phone number,email-id.");
                        newcontact = new Contact()
                        {
                            firstname = Console.ReadLine(),
                            lastname = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            city = Console.ReadLine(),
                            state=Console.ReadLine(),
                            zip=Console.ReadLine(),
                            phone_number=Console.ReadLine(),
                            email_id=Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Add contact in specific order:firstname,lastname,address,city,state,zip,phone.no,email-id");
                        newcontact = new Contact();
                        add.Addcontact(newcontact);
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phone_number = Console.ReadLine();
                        newcontact.email_id = Console.ReadLine();
                        add.Display();
                        break;         
                    case 3:
                        Console.WriteLine("enter the name of contact to be edit");
                        string user = Console.ReadLine();
                        add.Editcontact(user);
                        add.Display();
                        break;
                    case 4:
                        Console.WriteLine("enter the name of contact to be delete");
                        string name = Console.ReadLine();
                        add.DeleteContact(name);
                        add.Display();
                        break;
                    case 5:
                        Console.WriteLine("Entre the firstname as a uniquename");
                        string firstname = Console.ReadLine();
                        add.AddUniqueContact(firstname);
                        add.DisplayUniqueContact();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 6");
                        break;
                }
            }
        }
    }
}
