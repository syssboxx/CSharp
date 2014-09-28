//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class ShowSignOfProductOfNumbers
{
    static void Main()
    {
        float number1, number2, number3;
        
        Console.WriteLine("Enter 3 real numbers (on separate lines) :");
        number1 = float.Parse(Console.ReadLine());
        number2 = float.Parse(Console.ReadLine());
        number3 = float.Parse(Console.ReadLine());

        int counter=0;

        //if one of the 3 numbers is 0 all the product is 0
        if ((number1 == 0) || (number2 == 0) || (number3 == 0))
        {
            Console.WriteLine("The product is 0");
        }

       //count the number of the negative numbers and increments it
        else
        {
            if (number1 < 0)
            {
                counter++;
            }
            if (number2 < 0)
            {
                counter++;
            }
            if (number3 < 0)
            {
                counter++;
            }
            
            //if the counter is odd the sign is negative
            if ((counter % 2 != 0))
            {
                Console.WriteLine("The product is negative");
            }
            else
            {
                Console.WriteLine("The product is positive");
            }
        }  
        

 
    }
}
