using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetPassword("1234");

            person.LastName = "Sulecki";

            Console.WriteLine(person.GetPassword());

            Console.WriteLine(person.LastName);

            Console.ReadLine();

            
        }
    }
}
