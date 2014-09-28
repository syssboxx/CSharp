//Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class PrintDayOfWeekToday
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        //DateTime day = today.DayOfWeek;
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}
