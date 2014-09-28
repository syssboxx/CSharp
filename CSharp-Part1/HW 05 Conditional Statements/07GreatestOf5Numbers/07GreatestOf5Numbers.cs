//Write a program that finds the greatest of given 5 variables. 

using System;

class Program
{
    static void Main()
    {
        double number1, number2, number3, number4, number5;
        double greatest;

        Console.WriteLine("Enter 5 numbers :");

        number1 = int.Parse(Console.ReadLine());
        number2 = int.Parse(Console.ReadLine());
        number3 = int.Parse(Console.ReadLine());
        number4 = int.Parse(Console.ReadLine());
        number5 = int.Parse(Console.ReadLine());

        greatest = number1;
        if (greatest<number2)
        {
            greatest = number2;
        }
        if (greatest < number3)
        {
            greatest = number3;
        }
        if (greatest < number4)
        {
            greatest = number4;
        }
         if (greatest < number5)
        {
            greatest = number5;
        }
        
        Console.WriteLine("The greatest number is {0}", greatest);
    }
}
