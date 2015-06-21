using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address("Warszawa", "Chlodna", "00-001");

            int numberOfCopies = 5;

            address.Print(ref numberOfCopies);

            Person person = new Person();
            person.FirstName = "Piotr";
            person.LastName = "Wozniak";
            person.Age = 18;

            

            if (person.Age.HasValue)
            {
                Console.WriteLine("wiek: {0}", person.Age);
            }


            Person trener = (Person) person.Clone();

            trener = null;
            
            trener.FirstName = "Marcin";

            address.Print(person);

            Console.WriteLine(String.Format("Wydrukowano wizytowke dla {0} {1}", person.FirstName, person.LastName));

            

            // Document document = new Invoice();

            Console.WriteLine(String.Format("Wydrukowano {0} kopii", numberOfCopies));
            
            

        }
    }
}
