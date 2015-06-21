using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime endDate = DateTime.Today.AddDays(0);
            endDate = endDate.AddWorkingDays(10);

            // Fluent Datetime
            endDate = endDate.Hour(2).Minut
            
            if (endDate.IsHoliday())
            {
                Console.WriteLine("Wolne :)");
            }
            else 
            {
                Console.WriteLine("znow do pracy... :-/");
            }
            
        }

    }
}
