using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodDemo
{
    public static class DateTimeExtensions
    {
        public static DateTime AddWorkingDays(this DateTime date, int days)
        {
            return date.AddDays(days);
        }

        public static bool IsHoliday(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static int GetSize(this string text)
        {
            return text.Length;
        }
    }
}
