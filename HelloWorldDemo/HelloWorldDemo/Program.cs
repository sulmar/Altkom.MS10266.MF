using System;
using crypto = System.Security.Cryptography;
using Altkom;
using System.Threading;
using HelloWorldDemo.Properties;
using System.Numerics;
// using static System.Console; C# 6.0

namespace pl.gov.mf.HelloWorldDemo
{
    class Program
    {
        static readonly DateTime startedDate = DateTime.Now;

        static void Main(string[] args)
        {

            ArrayTest();
            
            CastTest();

            ConvertTest();

          //  DateTimeTest();

           // StringTest();

           // DecimalTest();

          //  IntTest();

           // HelloWorldTest();
        }

        private static void ArrayTest()
        {
            byte[,] plansza = new byte[4, 3];


            Console.WriteLine("Podaj rozmiar");

            int size = int.Parse(Console.ReadLine());

            byte[] numbers = new byte[size];
            string prefix = "Mr";

            numbers[0] = 9;
            numbers[1] = 10;
            numbers[2] = 43;
            numbers[3] = 32;
                      

        }

        private static void CastTest()
        {
            int a = 258;

            byte b;

            checked
            {
                b = (byte)a;
            }

            Console.WriteLine(b);
        }

        private static void ConvertTest()
        {
            Console.WriteLine("Podaj wiek");

            string inputAge = Console.ReadLine();

            byte age;

            if (byte.TryParse(inputAge, out age))
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("blednie podana wartosc");
            }



        }

        private static void DecimalTest()
        {
            decimal salary = 1000.67676m;

            Console.WriteLine("{0:n2}", salary );
        }

        private static void DateTimeTest()
        {
            DateTime data = DateTime.Now;

            Console.WriteLine(String.Format("{0:dd.mm.yyyy}", data));

        
        }

        private static void StringTest()
        {
            string firstName = "Marcin";

            char initial = firstName[0];            

            string full = firstName + initial;


        }

        private static void IntTest()
        {
            int x = 10;
            Int32 y = 10;
            
            Console.WriteLine(x);

            byte age = 99;

            Console.WriteLine(age);

            Int64 bignumber = 303000;

            BigInteger biginteger = 4000;



            


        }

        private static void HelloWorldTest()
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Podaj imię");
            string firstname = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko");
            string lastname = Console.ReadLine();

            int age = 19;

            // Witaj Marcin
            Console.WriteLine("Good evening " + firstname + " " + lastname + " na szkoleniu");

            Console.WriteLine(String.Format(Resources.Message, firstname, lastname));

            Console.WriteLine(String.Format("Witaj {0} {1} na szkoleniu", firstname, lastname));
        }

        
    }
}
