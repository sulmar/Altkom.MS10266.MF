using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodDemo
{
    class DateTimeHelper
    {
        public static bool IsHoliday(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
