using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMsmoothlogics 
{
    class ContactDatabase
    {
        Random _random = new Random();
        string[] _Names = { "Tanner Lauka", "Laura Longstreet", "Brett Swartz" };
        string[] _Addresses = { "555 East Main St.", "414 I-96", "In a van down by the river"};
        string[] _Emails = { "test@gmail.com", "test@hotmail.com", "test@aol.com"};
        string[] _PhoneNumbers = { "(989)555-5555", "(517)555-5555", "(616)555-5555" };

        public string GetRandomContactName
        {
            get { return _Names[_random.Next(_Names.Length)]; }
        }

        public string GetRandomContactAddress
        {
            get { return _Addresses[_random.Next(_Addresses.Length)]; }
        }

        public string GetRandomContactEmail
        {
            get { return _Emails[_random.Next(_Emails.Length)]; }
        }

        public string GetRandomContactPhoneNumber
        {
            get { return _PhoneNumbers[_random.Next(_PhoneNumbers.Length)]; }
        } 

    }
}
