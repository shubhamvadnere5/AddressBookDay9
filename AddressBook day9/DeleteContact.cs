using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_day9
{
    /// <summary>
    /// UC4 Delete contact
    /// </summary>
    class DeleteContact
    {
        public List<Contacts> personDetails = new List<Contacts>(); //create list of contacts

        public void AddingPerson()
        {
            Console.WriteLine("first name");
            string first_name = Console.ReadLine();
            
            Console.WriteLine("last name");
            string last_name = Console.ReadLine();

            Console.WriteLine("address");
            string address = Console.ReadLine();

            Console.WriteLine("city");
            string city = Console.ReadLine();

            Console.WriteLine("state");
            string state = Console.ReadLine();

            Console.WriteLine("zip");
            string zip = Console.ReadLine();

            Console.WriteLine("phone number");
            int phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email");
            string email = Console.ReadLine();

            Contacts person = new Contacts(first_name, last_name, address, city, state, zip, phonenumber, email);
            personDetails.Add(person);
            Print(person);

        }
        public void Print(Contacts Person)
        {
            Console.WriteLine("Address Book Details");
            Console.WriteLine("First Name:" + Person.firstName);
            Console.WriteLine("Last Name:" + Person.lastName);
            Console.WriteLine("Address:" + Person.address);
            Console.WriteLine("City:" + Person.city);
            Console.WriteLine("State:" + Person.state);
            Console.WriteLine("Zip:" + Person.zip);
            Console.WriteLine("Phonenumber:" + Person.phoneNumber);
            Console.WriteLine("Email:" + Person.email);
        }
        public void Edit() 
        {
            if (personDetails.Count != 0) // to check whether the data (number of rows) is present or not in object
            {
                Console.WriteLine("Enter contact to modify:"); // insert that value for which we wanted to do modification  
                string edit = Console.ReadLine();

                foreach (var person in personDetails)
                {
                    if (person.firstName.ToUpper() == edit.ToUpper())    // to match both the details i.e data from the database and user inserted converted into upper
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            // taking choices frpm the user so that we can performed opeartion accordingly
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");

                            int Option = Convert.ToInt32(Console.ReadLine());  // 2

                            switch (Option) // switch case evaluates the expression and run the cases accordingly Option = 1 then case 1 will get executed
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
                                    person.phoneNumber = Convert.ToInt32(Console.ReadLine());
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
                    else            // if wrong name has been inserted then this will be run
                    {
                        Console.WriteLine("Enter the valid name!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
            public void Delete()
            {
                
                    Console.WriteLine("Enter the name of person to Delete:"); // insert that value for which we wanted to do delete
                    string delete = Console.ReadLine();


                    foreach (var person in personDetails.ToList())
                    {
                        if (person.firstName.ToUpper() == delete.ToUpper())
                        {   
                            
                         personDetails.Remove(person);
                        Console.WriteLine("Contact is Deleted");
                        }

                    }
                

            }  
    }
}






    

