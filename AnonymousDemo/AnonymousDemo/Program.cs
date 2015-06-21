using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnonymousDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDay = DateTime.Parse("2008-06-12");

            var x = 10;
            
            var person1 = new
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                NIP = "9531204591",
                BirthDay = DateTime.Parse("2008-06-12"),
                HairColor = "Red",
                Salary = 123000.00m,
            };

            var person2 = new
            {
                FirstName = "Bartek",
                LastName = "Sulecki",
                NIP = "95221204591",
                BirthDay = DateTime.Parse("2008-06-12"),
                HairColor = "Brown",
                Salary = 999.00m,
            };

            var person3 = new
            {
                FirstName = "Piotr",
                LastName = "Wozniak",
                NIP = "11221204591",
                BirthDay = DateTime.Parse("2001-06-12"),
                HairColor = "Red",
                Salary = 110000.00m,
            };

            ArrayList persons = new ArrayList();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }




        }
    }
}
