using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PersonsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            var persons = repository.GetPersons(112000);

            foreach (var person in persons)
            {
                Console.WriteLine(String.Format("{0} - {1}", person, person.Salary));
            }


            // CollectionTest();
        }

        private static void CollectionTest()
        {
            var person1 = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                NIP = "9531204591",
                BirthDay = DateTime.Parse("2008-06-12"),
                HairColor = "Red",
                Salary = 123000.00m,
            };

            var person2 = new Person
            {
                FirstName = "Bartek",
                LastName = "Sulecki",
                NIP = "95221204591",
                BirthDay = DateTime.Parse("2008-06-12"),
                HairColor = "Brown",
                Salary = 999.00m,
            };

            var person3 = new Person
            {
                FirstName = "Piotr",
                LastName = "Wozniak",
                NIP = "11221204591",
                BirthDay = DateTime.Parse("2001-06-12"),
                HairColor = "Red",
                Salary = 110000.00m,
            };

            var persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);


            persons.Remove(person2);

            var printer = new Printer<Person>();


            //var numbersPrinter = new Printer<int>();

            //numbersPrinter.Print(100);

            // Kolejka
            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(person3);
            queue.Enqueue(person1);
            queue.Enqueue(person2);

            var patient3 = queue.Peek();

            var patient1 = queue.Dequeue();
            var patient2 = queue.Dequeue();


            foreach (var person in queue)
            {
                Console.WriteLine(person);
            }
        }
    }
}
