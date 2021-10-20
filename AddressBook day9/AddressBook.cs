using AddressBook_day9;
using System;
using System.Collections.Generic;

namespace AddressBook_day9
   
    /// //Uc6 create multiple address book
//creating object person from Contact class
class AddressBook
     {   
    public LinkedList<Contacts> personDetails = new LinkedList<Contacts>();

    //Creating a method for adding contacts in adrressbook
    public void AddPerson()
    {
        Contacts person = new Contacts();
        Console.WriteLine("Enter first name");
        person.firstName = Console.ReadLine();
        Console.WriteLine("Enter last name");
        person.lastName = Console.ReadLine();
        Console.WriteLine("Enter address name");
        person.address = Console.ReadLine();
        Console.WriteLine("Enter city name");
        person.city = Console.ReadLine();
        Console.WriteLine("Enter state name");
        person.state = Console.ReadLine();
        Console.WriteLine("Enter zip name");
        person.zip = Console.ReadLine();
        Console.WriteLine("Enter phone number");
        person.phoneNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter email id");
        person.email = Console.ReadLine();
        personDetails.AddLast(person);
    }

    //Printing the address book details 
    public void Print()
    {
        if (personDetails.Count == 0)
        {
            Console.WriteLine("Your address book is empty.");
            return;
        }
        else
        {
            foreach (Contacts person in personDetails)
            {
                Console.WriteLine("---Address book details----");
                Console.WriteLine("First Name:" + person.firstName);
                Console.WriteLine("Last Name:" + person.lastName);
                Console.WriteLine("Address:" + person.address);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("State:" + person.state);
                Console.WriteLine("Zip:" + person.zip);
                Console.WriteLine("Phone Number:" + person.phoneNumber);
                Console.WriteLine("Email:" + person.email);
            }
        }
    }
    //creating method for editing existing contact in address book
    public void Edit()
    {
        if (personDetails.Count != 0)
        {
            Console.WriteLine("Enter contact to modify:");
            string edit = Console.ReadLine();
            foreach (var person in personDetails)
            {
                //ToUpper used to convert to uppercase 
                if (person.firstName.ToUpper() == edit.ToUpper())
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the option to modify the property: ");
                        Console.WriteLine("Enter 1 to Change First name ");
                        Console.WriteLine("Enter 2 to Change Last name ");
                        Console.WriteLine("Enter 3 to Change Phone Number ");
                        Console.WriteLine("Enter 4 to Change Address ");
                        Console.WriteLine("Enter 5 to Change City ");
                        Console.WriteLine("Enter 6 to Change State ");
                        Console.WriteLine("Enter 7 to Change Pincode ");
                        Console.WriteLine("Enter 8 to Exit ");
                        int Option = Convert.ToInt32(Console.ReadLine());
                        //Switch case statement taken to choose desired operation
                        switch (Option)
                        {
                            case 1:
                                Console.WriteLine("Enter the New First Name: ");
                                person.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the New Last Name: ");
                                person.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the New Phone Number: ");
                                person.phoneNumber =Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter the New Address: ");
                                person.address = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the New City: ");
                                person.city = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the New State: ");
                                person.state = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the New Pin Code: ");
                                person.zip = Console.ReadLine();
                                break;
                            case 8:
                                return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Contact does not exist");
                }
            }
        }
        else
        {
            Console.WriteLine("Your address book is empty");
        }
    }

    //method for deleating or remove a existing contact
    public void Delete()
    {
        Console.WriteLine("Enter the first name of the person you would like to remove.");
        string delete = Console.ReadLine();
        //Tolist() used to return a new list,means input converted to list
        foreach (var person in personDetails)
        {
            if (person.firstName.ToUpper() == delete.ToUpper())
            {
                Console.WriteLine("Are you sure you want to delete this contact?(Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    personDetails.Remove(person);
                    Console.WriteLine("\nContact is deleted");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Contact is not present");
            }
        }
    }
}
