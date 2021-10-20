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
                Console.WriteLine("---Welcome to your Address Book--");
                //creating object person1 of AddressBook Class()
                AddressBook person1 = new AddressBook();
                while (true)
                {
                    Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-Edit a existing contact \n 3-View Address book contacts \n 4-Delete existing contact \n 5-Exit from the Addressbook");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            person1.AddPerson();
                            Console.WriteLine("Enter any key to exit");
                            break;
                        case 2:
                            person1.Edit();
                            break;
                        case 3:
                            person1.Print();
                            Console.WriteLine("Enter any key to exit");
                            break;
                        case 4:
                            person1.Delete();
                            Console.WriteLine("Enter any key to exit");
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }