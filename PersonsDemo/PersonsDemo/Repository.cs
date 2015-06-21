using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsDemo
{
    class Repository
    {

        public List<Person> GetPersons(decimal salaryLimit)
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

            // klasycznie

            var result = new List<Person>();

            foreach (var person in persons)
            {
                if (person.Salary < salaryLimit)
                {
                    result.Add(person);
                }
            }

            

            var result3 = persons                
                .Where(person => person.Salary < salaryLimit)
                .Where(person => person.HairColor.ToLower() == "red".ToLower())
                .OrderByDescending(person => person.Salary)
                .Take(2)
                //.Select(person => new Person
                //    { 
                //        FirstName = person.FullName,                        
                //        Salary = person.Salary 
                //    })
                .ToList();

            var result4 = (
                          from person in persons
                          where person.Salary < salaryLimit
                          && person.HairColor.ToLower() == "red".ToLower()
                          orderby person.Salary descending
                          select new { person.FirstName, person.LastName }
                          )
                          .Take(2)
                          .ToList();

                          

            return result3;


        }
    }
}
