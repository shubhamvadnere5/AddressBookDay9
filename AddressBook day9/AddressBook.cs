using AddressBook_day9;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook_day9
{

    class AddressBook
    {   //Uc9 view person by citylist and state list

        public static Dictionary<string, List<AddressBook>> City = new Dictionary<string, List<AddressBook>>();
        public static Dictionary<string, List<AddressBook>> State = new Dictionary<string, List<AddressBook>>();
        public List<AddressBook> personDetails;
        public List<AddressBook> stateDetails;
        public List<AddressBook> cityDetails;
        public List<AddressBook> existingCityorState;

        //Default constructor
        public AddressBook()
        {
            personDetails = new List<AddressBook>();
        }

        //Decalring instance variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNum;
        public string emailId;

        //Parameterized constructor
        public AddressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zip;
            this.phoneNum = phoneNumber;
            this.emailId = email;
        }

        //Adding deatils of a contact in address book
        public void AddPerson()
        {
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            string Addresses = Console.ReadLine();
            Console.Write("Enter City : ");
            string City = Console.ReadLine();
            Console.Write("Enter State : ");
            string State = Console.ReadLine();
            Console.Write("Enter PinCode: ");
            string ZipCode = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            Console.Write("Enter EmailId: ");
            string EmailId = Console.ReadLine();
            CreateContact(FirstName, LastName, Addresses, City, State, ZipCode, PhoneNumber, EmailId);
        }

        //Getting the user details
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNum, string emailId)
        {
            int contact = 0;
            AddressBook person = new AddressBook(firstName, lastName, address, city, state, zipCode, phoneNum, emailId);
            if (contact == 0)
            {
                personDetails.Add(person);
                Print(person);
                if (State.ContainsKey(state))
                {
                    existingCityorState = State[state];
                    existingCityorState.Add(person);
                }
                else
                {
                    stateDetails = new List<AddressBook>();
                    stateDetails.Add(person);
                    State.Add(state, stateDetails);
                }
                if (City.ContainsKey(city))
                {
                    existingCityorState = City[city];
                    existingCityorState.Add(person);
                }
                else
                {
                    cityDetails = new List<AddressBook>();
                    cityDetails.Add(person);
                    City.Add(city, cityDetails);
                }
                contact++;
            }
            else if (contact != 0)
            {
                //Checking duplicates by using lambda
                AddressBook addressBooks = personDetails.Find(x => x.firstName.Equals(firstName));
                if (addressBooks == null)
                {
                    person = new AddressBook(firstName, lastName, address, city, state, zipCode, phoneNum, emailId);
                    personDetails.Add(person);
                    Print(person);
                    if (State.ContainsKey(state))
                    {
                        existingCityorState = State[state];
                        existingCityorState.Add(person);

                    }
                    else
                    {
                        stateDetails = new List<AddressBook>();
                        stateDetails.Add(person);
                        State.Add(state, stateDetails);

                    }
                    if (City.ContainsKey(city))
                    {
                        existingCityorState = City[city];
                        existingCityorState.Add(person);
                    }
                    else
                    {
                        cityDetails = new List<AddressBook>();
                        cityDetails.Add(person);
                        City.Add(city, cityDetails);
                    }
                    contact++;
                }
                else
                {
                    Console.WriteLine("This person already exists in your AddressBook!");
                }
            }
        }

        //Printing the address book details 
        public void Print(AddressBook person)
        {
            if (personDetails.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                return;
            }
            else
            {
                Console.WriteLine("---Address book details----");
                Console.WriteLine("First Name:" + person.firstName);
                Console.WriteLine("Last Name:" + person.lastName);
                Console.WriteLine("Address:" + person.address);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("State:" + person.state);
                Console.WriteLine("Zip:" + person.zipCode);
                Console.WriteLine("Phone Number:" + person.phoneNum);
                Console.WriteLine("Email:" + person.emailId);
            }
        }

        //Uc9 for creating method to view person by city or state
        public void ViewCityorState(int option)
        {
            if (option == 1)
            {
                foreach (var cityName in City)
                {
                    Console.WriteLine("Display List for City: {0}", cityName.Key);
                    foreach (var item in cityName.Value)
                    {
                        Console.WriteLine("The contact person {0} , staying in {1} City", item.firstName, item.city);
                    }
                }
            }
            else
            {
                foreach (var stateName in State)
                {
                    Console.WriteLine("Display List for State: {0}\n", stateName.Key);
                    foreach (var item in stateName.Value)
                    {
                        Console.WriteLine("The contact person {0}, belongs to {1} State", item.firstName, item.state);
                    }
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
                            Console.WriteLine("Enter 8 to Change Email ");
                            Console.WriteLine("Enter 9 to Exit ");
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
                                    person.phoneNum = Console.ReadLine();
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
                                    person.zipCode = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the New Pin Email: ");
                                    person.emailId = Console.ReadLine();
                                    break;
                                case 9:
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
}
