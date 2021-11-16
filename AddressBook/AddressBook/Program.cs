using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK SYSTEM");
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("CHOOSE OPTION\n1.Create Contact\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("create contact in specific order:firstname,lastname,address,city,state,zip,phone number,email-id.");
                        Contact contact = new Contact
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
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 2");
                        break;
                }
            }
        }
    }
}
