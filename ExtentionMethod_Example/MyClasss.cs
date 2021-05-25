using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExtentionMethod_Example
{
    public static class MyClasss
    {
        public static string ToRial(this int value)
        {
            return value.ToString("#,0 Tooman");
        }

        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar persianCalendar=new PersianCalendar();
            return $"{persianCalendar.GetYear(value)}/{persianCalendar.GetMonth(value).ToString("00")}/{persianCalendar.GetDayOfMonth(value).ToString("00")}";
        }
    }
}
