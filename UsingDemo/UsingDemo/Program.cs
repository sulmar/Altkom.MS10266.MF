using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate();
        }

        private static void Generate()
        {
            try
            {
                using (DataService service = new DataService())
                {
                    string filename = @"C:\Users\Student\Documents\testXXX.xml";

                    service.Prepare(filename);
                    service.Send();

                    Console.WriteLine("success.");
                }
            }
            catch (Exception e)
            {

            }

        

        }
    }
}
