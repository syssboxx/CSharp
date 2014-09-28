//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;

class WorkingDaysBetweenTwoDates
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        DateTime userDate = new DateTime();

        TimeSpan period = new TimeSpan();
        int daysInPeriod = 0;

        DateTime[] holidays = 
        { 
            new DateTime(2013, 9, 6), 
            new DateTime(2012, 9, 22), 
            new DateTime(2012, 12, 24), 
            new DateTime(2012, 12, 25), 
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31) 
        };


        bool isHoliday = false;
        int numberOfWorkingDays = 0;

        Console.Write("Enter a date in the format YYYY,MM,DD (2013,08,11) :");
        userDate = DateTime.Parse(Console.ReadLine());

        //compare the 2 dates and exchange their value is the user date is smaller than today
        //and calculate how many days are between
        if (userDate>today)
        {
            period = userDate - today;
        }
        else if (userDate<today)
        {
            today = userDate;
            userDate = DateTime.Today;
            period = userDate-today;
        }
        else
        {
            Console.WriteLine("The 2 dates are the same.");
            Console.WriteLine("There's no working days between them.6");
        }
        daysInPeriod = period.Days;

        //check the days in the period if they are holidays

        for (int i = 0; i < daysInPeriod; i++)
        {
            today = today.AddDays(1);
            if ((today.DayOfWeek!=DayOfWeek.Saturday)&&(today.DayOfWeek!=DayOfWeek.Sunday))
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (today==holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    numberOfWorkingDays++;
                }
                isHoliday = false;
            }
        }

        Console.WriteLine("There are {0} days between today and {1:d}", period.Days, userDate);
        Console.WriteLine("Working Days in the period : {0}",numberOfWorkingDays);
        
    }
}