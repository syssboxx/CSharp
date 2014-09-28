//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class FindGreaterOfTwoNumbers
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        double greater;
        double smaller;

        Console.WriteLine("Let's compare two numbers.\nEnter first number : ");
        firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second nuber : ");
        secondNumber = double.Parse(Console.ReadLine());

        greater = Math.Max(firstNumber, secondNumber);
        smaller = Math.Min(firstNumber, secondNumber);

        Console.WriteLine("The greater of {0} and {1} is {2}", firstNumber, secondNumber, greater);

        /* II solution
         


        /*
        greater = firstNumber > secondNumber ? firstNumber : secondNumber;
        Console.WriteLine("The greater of {0} and {1} is {2}",firstNumber,secondNumber,greater);
          */

       
    }
}
