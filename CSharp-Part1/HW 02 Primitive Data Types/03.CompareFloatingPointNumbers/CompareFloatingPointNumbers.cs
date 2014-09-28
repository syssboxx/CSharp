//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        /*
        Console.WriteLine("Enter 2 floating point numbers to comppare with precision of 0,000001.\nFirst number : ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Second number : ");
        float secondNumber = float.Parse(Console.ReadLine());
        bool checkPrecision = firstNumber == secondNumber;
        Console.WriteLine("{0:F8};{1:F8}->{2}",firstNumber, secondNumber,checkPrecision);
         * */

        decimal a = 5.3m;
        decimal b = 6.01m;

        decimal a2 = 5.000000001m;
        decimal b2 = 5.00000003m;

        decimal precision = 0.000001m;

        bool equalAB = Math.Abs(a - b) < precision;
        Console.WriteLine("Are number {0} and {1} equal? {2}", a, b, equalAB);

        bool equalAB2 = Math.Abs(a2 - b2) < precision;
        Console.WriteLine("Are number {0} and {1} equal? {2}", a2, b2, equalAB2);


    }
}

