using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_day9
{
    /// <summary>
    /// UC2 Adding contact
    /// </summary>
    class Addingnewcontact
    {
        public List<Contacts> personDetails = new List<Contacts>();

        private void AddingPerson()
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
        private void Print(Contacts Person)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Addingnewcontact person1 = new Addingnewcontact();
            person1.AddingPerson();
            Console.ReadLine();
        }



    }
}

