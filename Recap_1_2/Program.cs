using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object that upon initilization holds these values:
            // first name = "John"
            // last name = "Johnakis"
            // full name = "John Johnakis"
            // email = "john@johnakis.com"
            // mobile = "1234567890"
            // adt = "AA123456"
            Person person = new Person();
            Console.WriteLine(person);
            person.FirstName = "Test";
            Console.WriteLine(person);

        }
    }
}
