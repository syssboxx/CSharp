//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
//another solution 

using System;

class FindGreaterOfTwoNumbers_2
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

        greater = (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber)) / 2;
        smaller = (firstNumber + secondNumber - Math.Abs(firstNumber - secondNumber)) / 2;

        Console.WriteLine("The greater of {0} and {1} is {2}", firstNumber, secondNumber, greater);

         /*
        greater = firstNumber > secondNumber ? firstNumber : secondNumber;
        Console.WriteLine("The greater of {0} and {1} is {2}",firstNumber,secondNumber,greater);
          */


    }
}
