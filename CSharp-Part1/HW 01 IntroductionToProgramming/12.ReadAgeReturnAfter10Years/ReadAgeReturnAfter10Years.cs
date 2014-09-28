//Write a program to read your age from the console and print how old you will be after 10 years.

using System;


class ReadAgeReturnAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your date of birthday in format 'dd mm yyyy' :");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        
        TimeSpan tsAgesNow = DateTime.Today - inputDate;
        DateTime agesNow = DateTime.MinValue; //initialise to 01 01 0001
        agesNow = agesNow.Add(tsAgesNow);
        Console.WriteLine("You are {0} years old", agesNow.Year - 1); //substract 1 year, because initial year is 0001

        DateTime after10 = agesNow.AddYears(10);
        Console.WriteLine("Your age after 10 years will be {0}.",after10.Year - 1); //substract 1 year, because initial year is 0001
       
    }
}

