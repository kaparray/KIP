using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs20
  { class Program
    {
        static void Main()
        {
            Console.Title = "Лабараторная №20 Адещенко Кирилл";
            Console.WriteLine(" Дата и время в системе Win \n");

            string[] MONTH = new string[12];
       MONTH[0] = "январь"; MONTH[1] = "февраль";
            MONTH[2] = "март"; MONTH[3] = "апрель";
            MONTH[4] = "май"; MONTH[5] = " июнь";
            MONTH[6] = "июль"; MONTH[7] = " август";
            MONTH[8] = " сентябрь"; MONTH[9] = " октябрь";
            MONTH[10] = " ноябрь"; MONTH[11] = " декабрь";
            // date time
            DateTime dt = DateTime.Now; 
            Console.WriteLine(" текущие дата и время " + dt);
            // date
            DateTime date = dt.Date;
            Console.WriteLine(" число " + date);
            // month
            int month = dt.Month;
            Console.WriteLine(" месяц " + MONTH[month - 1] + "(" + month + ")");
            // year
            int year = dt.Year; Console.WriteLine(" год " + year);
            Console.WriteLine(" час мин. сек. мсек.");

            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;
            int millisecond = dt.Millisecond;
            Console.WriteLine("  " + hour + "   " + minute + "   " + second + "  " + millisecond);
            System.Threading.Thread.Sleep(1000000); // be careful, thread not sleap moor then long in 64 bit system 

        }
    }
}