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
        public static Dictionary<string, List<AddressBook>> addressBook = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> City = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> State = new Dictionary<string, List<AddressBook>>();
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
                while (contactNum > 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");
                    person1.AddPerson();
                    contactNum -= 1;
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
            foreach (KeyValuePair<string, List<AddressBook>> item in addressBook)
            {
                Console.WriteLine("Existing address books are {0}", item.Key);
                Console.WriteLine("Enter any key to continue");
                Console.ReadLine();
            }
            Console.WriteLine("Choose one operation to perform:\n 1-Edit a existing contact \n 2-Delete existing contact \n 3-View by city or state \n 4-Get persons counted by city or state \n 5-Sort the address book alphabatically \n 6-Exit from the operation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    person1.Edit();
                    Console.WriteLine("Enter any key to continue");
                    break;
                case 2:
                    person1.Delete();
                    Console.WriteLine("Enter any key to continue");
                    break;
                case 3:
                    Console.WriteLine("Enter option to view person by city or state\n 1-To view City list\n 2-To view State list");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    person1.ViewCityorState(opt);
                    Console.WriteLine("Enter any key to continue");
                    break;
                case 4:
                    Console.WriteLine("Get number of person, count by city or state");
                    person1.DisplayCount();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Sorting the address book in alphabatically manner");
                    person1.SortingContactAlphabatically(addressBook);
                    Console.ReadLine();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }
    }
}




