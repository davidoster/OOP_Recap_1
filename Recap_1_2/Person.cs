using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_1_2
{
    internal class Person
    {
        // first name = "John"
        // last name = "Johnakis"
        // full name = "John Johnakis"
        // email = "john@johnakis.com"
        // mobile = "1234567890"
        // adt = "AA123456"

        private string _firstName;
        public string FirstName {
            get 
            { 
                return _firstName; 
            } 
            set
            {
                _firstName = value;
                //FullName = _firstName + " " + _lastName;
            }
        }

        private string _lastName;
        public string LastName {
            get
            {
                return _lastName;
            }
            
            set 
            { 
                _lastName = value;
                //FullName = _firstName + " " + _lastName;
            }
        }
        public string FullName {
            get 
            { 
                return _firstName + " " + _lastName; 
            } 
            
            private set
            {

            } 
        }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string ADT { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Johnakis";
            Console.WriteLine(FullName);
            Email = "john@johnakis.com";
            Mobile = "1234567890";
            ADT = "AA123456";
        }

        public override string ToString()
        {
            return $"{FirstName}\t{_lastName}\t{FullName}\t{Email}\t{Mobile}\t{ADT}";
        }
    }
}
