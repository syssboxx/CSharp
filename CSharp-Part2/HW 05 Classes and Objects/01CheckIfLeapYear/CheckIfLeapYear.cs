//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


using System;

class CheckIfLeapYear
{
    static void Main()
    {
         Console.WriteLine("Enter a year");
         int year = int.Parse(Console.ReadLine());
        
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is leap year",year);
        }
        else
        {
            Console.WriteLine("Year {0} is NOT leap year", year);
        }
    }
}
