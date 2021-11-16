using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookList
    {
        List<Contact> addresslist = new List<Contact>();
        public void Addcontact(Contact contact) 
        {
            addresslist.Add(contact);
        }
        public void Display()
        {
            foreach(var contact in addresslist)
            {
                Console.WriteLine("firstname =" + contact.firstname);
                Console.WriteLine("lastname =" + contact.lastname);
                Console.WriteLine("Address =" + contact.Address);
                Console.WriteLine("City =" + contact.city);
                Console.WriteLine("State =" + contact.state);
                Console.WriteLine("Zip =" + contact.zip);
                Console.WriteLine("Phone-Number =" + contact.phone_number);
                Console.WriteLine("Email-Id =" + contact.email_id);
            }
        }
    }
}
