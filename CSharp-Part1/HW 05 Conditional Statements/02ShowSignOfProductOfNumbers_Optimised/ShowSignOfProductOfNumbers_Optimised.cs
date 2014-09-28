//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class ShowSignOfProductOfNumbers_optimised
{
    static void Main()
    {
        float number1, number2, number3;

        Console.WriteLine("Enter 3 real numbers (on separate lines) :");
        number1 = float.Parse(Console.ReadLine());
        number2 = float.Parse(Console.ReadLine());
        number3 = float.Parse(Console.ReadLine());

        //if one of the 3 numbers is 0 all the product is 0
       if ((number1 == 0) || (number2 == 0) || (number3 == 0))
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
           //check if there's 2 numbers with the same sign and check only the third sign
            if (((number1 > 0) && (number2 > 0)) || ((number1 < 0) && (number2 < 0)))
            {
                if (number3 > 0)
                {
                    Console.WriteLine("The sign of the product of {0},{1},{2} is positive", number1, number2, number3);
                }
                else
                {
                    Console.WriteLine("The sign of the product of {0},{1},{2} is negative", number1, number2, number3);
                }
            }
        }
     
    }
}
