using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.

            DocumentType type = DocumentType.FZ;

            if (type == DocumentType.KO)
            {
            }

             CalculateTest();
        }

        private static void CalculateTest()
        {
            Calculator calculator = new Calculator();
            calculator.Send("");


            decimal result = calculator.Calculate(0m, 1.23m);

            Console.WriteLine(result);
        }
    }
}
