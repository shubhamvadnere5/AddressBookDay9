using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_day9
{
    class Mainmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Address Book");
            //creating object person1 of AddressBook Class()
            DeleteContact person1 = new DeleteContact();
            while (true)
            {
                Console.WriteLine("Choose one operation to perform");
                Console.WriteLine("1- Add the Contacts");
                Console.WriteLine("2- Edit the existing person Contact");
                Console.WriteLine("3- Delete the person contact");
                Console.WriteLine("4- View the Addressbook");
                Console.WriteLine("5- Exit the Addressbook");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        person1.AddingPerson();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 2:
                        person1.Edit();
                        break;
                    case 3:
                        person1.Delete();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}