//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).
//TO TEST 
//gcd(48,18)=6
//gcd(8,12)=4

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = int.Parse(Console.ReadLine());
        int greatestCommonDivisor;
        int remainder;
        int number1;
        int number2;

        //for the calculations i need that the first number is bigger than the second
        //i make a comparison anf if second>first i swap them
        if ((num1>0)&&(num2>0))
        {
            if (num1 < num2)
            {
                number2 = num1;
                number1 = num2;
            }
            else
            {
                number2 = num2;
                number1 = num1;
            }

            do
            {
                remainder = number1 % number2;
                number1 = number2;
                number2 = remainder;
             }
            while (remainder != 0);

            greatestCommonDivisor = number1;
            Console.WriteLine(greatestCommonDivisor);
        }
        else
        {
            Console.WriteLine("error");     
        }
    }
}
