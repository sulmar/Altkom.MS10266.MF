using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDemo
{
    struct Address
    {
        public string city;
        public string street;
        public string postCode;

        public Address(string city, string street, string postCode)
        {
            this.city = city;
            this.street = street;
            this.postCode = postCode;
        }

        public void Print(ref int copies)
        {
            copies = 3;

            for (int copy = 0; copy < copies; copy++)
            {                
                Console.WriteLine(String.Format("{0} {1} {2}", city, street, postCode));    
            }
        }

        public void Print(Person person)
        {
            person.LastName = "Sulecki";

            Console.WriteLine(String.Format("{0} {1}", person.FirstName, person.LastName));
        }

    }
}
