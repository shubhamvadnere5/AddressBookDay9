using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_day9
{
    class Mainmethod
    {
       
        //Declaring a dictionary to store multiple contacts with the help of key
        public static Dictionary<string, List<Contacts>> addressBook = new Dictionary<string, List<Contacts>>();
        //creating object person1 of AddressBook Class()
        public static AddressBook person1 = new AddressBook();

        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to your Address Book--");
            Console.WriteLine("Enter the number of address books want to add: ");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the name of the address book: ");
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter the no of contacts you want to add in the address book: ");
                int contactNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose one operation to perform:\n 1-Add a new contact \n 2-Edit a existing contact \n 3-Delete existing contact \n 4-Exit from the operation");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        while (contactNum > 0)
                        {
                            Console.WriteLine("Enter the details of contact to be added: ");
                            person1.AddPerson();
                            contactNum -= 1;
                            person1.Print();
                        }
                        break;
                    case 2:
                        person1.Edit();
                        person1.Print();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 3:
                        person1.Delete();
                        person1.Print();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
                //check if added address book is exist or not, using method of contains key, if not add that
                if (addressBook.ContainsKey(bookName))
                {
                    Console.WriteLine("Address book is already exists");
                    return;
                }
                else
                {
                    addressBook.Add(bookName, person1.personDetails);
                }
                noOfBooks++;
            }
            foreach (KeyValuePair<string, List<Contacts>> item in addressBook)
            {
                Console.WriteLine("Existing address books are {0}", item.Key);
                Console.WriteLine("Enter any key to continue");
                Console.ReadLine();
            }

            //Search name based on city or state UC8
            SearchCity();
        }

        //method for searching city in the multiple address book
        public static void SearchCity()
        {
            Console.WriteLine("Search person based on city or state");
            Console.WriteLine("Enter City or State");
            string cityStateName = Console.ReadLine();
            //using keyvalue to get value of the key.
            foreach (KeyValuePair<string, List<Contacts>> kvp in addressBook)
            {
                Console.WriteLine("The address Books is:{0}", kvp.Key);
                Console.WriteLine("The Contact List from {0}", cityStateName);
                person1.SearchbyCityorState(kvp.Value, cityStateName);
                Console.ReadLine();
            }
        }
    }
}


