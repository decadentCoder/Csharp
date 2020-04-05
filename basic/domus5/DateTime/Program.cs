using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime emptyDate = new DateTime();

            DateTime current = DateTime.Today;
            DateTime days3FromNow = current.AddDays(3);
            DateTime days3andMonthFromNow = days3FromNow.AddMonths(1);
            DateTime yearAnd2MonthsAgo = current.AddYears(-1).AddMonths(-2);
            //string currentMonthOnly = current.ToString("MM");
            string currentMonthOnlyFormated = string.Format("Today is {0:MM}. month of the year", current);
            string currentYear = string.Format("The year is {0:yyyy}", current);

            Console.WriteLine(current);
            Console.WriteLine(days3FromNow);
            Console.WriteLine(days3andMonthFromNow);
            Console.WriteLine(yearAnd2MonthsAgo);
            Console.WriteLine(currentMonthOnlyFormated);
            Console.WriteLine(currentYear);
            Console.ReadLine();
        }
       
    }
}
