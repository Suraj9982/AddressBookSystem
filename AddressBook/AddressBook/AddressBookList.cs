using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookList
    {
       public List<Contact> addresslist = new List<Contact>();
       public static Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>(); 
        public void Addcontact(Contact contact) 
        {
            addresslist.Add(contact);
        }
        public void Editcontact(string name)
        {
            foreach (var contact in addresslist)
            {
                if (contact.firstname == name || contact.lastname == name)
                {
                    bool flag = true;
                    while (flag == true)
                    {
                        Console.WriteLine("what to be edited:\n1.firstname\n2.lastname\n3.address\n4.city\n5.state\n6.zip\n7.phone.no\n8.email-id\n9.exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                string Firstname = Console.ReadLine();
                                contact.firstname = Firstname;
                                Display();
                                break;
                            case 2:
                                string Lastname = Console.ReadLine();
                                contact.lastname = Lastname;
                                Display();
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Display();
                                break;
                            case 4:
                                string City = Console.ReadLine();
                                contact.city = City;
                                Display();
                                break;
                            case 5:
                                string State = Console.ReadLine();
                                contact.state = State;
                                Display();
                                break;
                            case 6:
                                string Zip = Console.ReadLine();
                                contact.zip = Zip;
                                Display();
                                break;
                            case 7:
                                string PhoneNo = Console.ReadLine();
                                contact.phone_number = PhoneNo;
                                Display();
                                break;
                            case 8:
                                string emailid = Console.ReadLine();
                                contact.email_id = emailid;
                                Display();
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("your choice should be between 1 to 9");
                                break;
                        }
                    }
                }
            }
        }
        public void Display()
        {
            foreach(var contact in addresslist)
            {
                Console.WriteLine("firstname =" + contact.firstname+"\nlastname =" + contact.lastname+ "\njAddress =" + contact.Address+ "\nCity =" + contact.city+ "\nState =" + contact.state+ "\nZip =" + contact.zip+ "\nPhone-Number =" + contact.phone_number+ "Email-Id =" + contact.email_id);
            }
        }
        public void DeleteContact(string name)
        {
            Contact delete = new Contact();
            foreach(var contact in addresslist.ToList())
            {
                if (contact.firstname == name || contact.lastname == name)
                {
                    delete = contact;
                }
                addresslist.Remove(delete);
                Console.WriteLine(name + "contact has deleted");
            }
        }
        public void AddUniqueContact(string firstname)
        {
            foreach(var contact in addresslist)
            {
                if (addresslist.Contains(contact))
                {
                    string uniquename = Console.ReadLine();
                    dict.Add(uniquename, addresslist);
                }
            }
        }
        public void DisplayUniqueContact()
        {
            Console.WriteLine("Enter the name of dictionary");
            string firstname = Console.ReadLine();
            foreach(var contact in dict)
            {
                if (contact.Key == firstname)
                {
                    foreach(var item in contact.Value)
                    {
                        Console.WriteLine("Firstname:"+item.firstname+"\n"+"lastname:"+item.lastname+"\n"+"Address:"+item.Address+"\n"+"City:"+item.city+"\n"+"State:"+item.state+"\n"+"Zip:"+item.zip+"\n"+"Phone.No-"+item.phone_number+"\n"+"Email.Id:"+item.email_id);
                    }
                }
            }
        }
        public void CheckDuplicate(List<Contact> contact,Contact newcontact)
        {
           foreach(var item in contact)
            {
                var person = contact.Find(e => e.firstname.Equals(newcontact.firstname));
                if (person != null)
                {
                    Console.WriteLine("this person already exist in addressbook with same firstname");
                }
                else
                {
                    Console.WriteLine("Add another conatct");
                }
            }       
        }
        public void Search()
        {
            Dictionary<string, List<Contact>> cityPerson = new Dictionary<string, List<Contact>>();
            Dictionary<string, List<Contact>> statePerson = new Dictionary<string, List<Contact>>();
            Console.WriteLine("enter the city that you want to search");
            string city = Console.ReadLine();
            cityPerson[city] = new List<Contact>();
            Console.WriteLine("enter the state that you want to search");
            string state = Console.ReadLine();
            statePerson[state] = new List<Contact>();
            foreach(string addressbooknames in dict.Keys)
            {
                foreach(Contact contact in dict[addressbooknames])
                {
                    if (city.ToLower() == contact.city)
                    {
                        cityPerson[city].Add(contact);
                    }
                    if (state.ToLower() == contact.state)
                    {
                        statePerson[state].Add(contact);
                    }
                }
            }
           SearchDisplay(cityPerson, statePerson, city, state);
        }
        public static void SearchDisplay(Dictionary<string,List<Contact>> cityPerson,Dictionary<string,List<Contact>> statePersons,string city,string state)
        {
            Console.WriteLine("------------------- Persons in {0} city-------------------------", city);
            foreach (Contact contact in cityPerson[city])
            {
                Console.WriteLine("{0}", contact.firstname);
            }
            Console.WriteLine("Total count of persons in the city {0} is {1}", city, cityPerson[city].Count);
            Console.WriteLine("--------------------Persons in {0} state", state);
            foreach (Contact contact in statePersons[state])
            {
                Console.WriteLine("{0}", contact.firstname);
            }
            Console.WriteLine("Total count of persons in the state {0} is {1}", state, statePersons[state].Count);
        }
    }
}
