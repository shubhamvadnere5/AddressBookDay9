using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_day9
{
    /// <summary>
    /// UC1 Create Contact
    /// </summary>
    class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public int phoneNumber;
        public string email;

        public Contacts()
        {
        }

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, int phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to Address Book Program");
//            Console.ReadLine();
//        }
//    }
//}
