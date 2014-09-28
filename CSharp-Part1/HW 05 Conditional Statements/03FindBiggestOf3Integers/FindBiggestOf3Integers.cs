//Write a program that finds the biggest of three integers using nested if statements.

//TO TEST
//123
//132
//213
//231
//321
//312

using System;

class FindBiggestOf3Integers
{
    static void Main()
    {
        int a, b, c;
        int biggest;

        Console.WriteLine("Enter 3 real numbers (on separate lines) :");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());


        biggest = a;
        if ((a == b) && (a == c) && (b == c))
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            if (a > b)
            {
                if (c < a) //it includes cases c<b<a && b<c<a
                {
                    biggest = a;
                }
                else if (c > a)
                {
                    biggest = c;
                }

            }
            else // (a<b)
            {
                if (c > b)
                {
                    biggest = c;
                }
                else // c<b
                {
                    biggest = b;
                }

            }
            Console.WriteLine("The biggest number is {0}", biggest);

            //another solution
            /*
             * if (a > b && a > c)
            {
                biggest = a;
            }
            else if (b > a && b > c)
            {
                biggest = secondNum;
            }
            else if (c > a && c > b)
            {
                biggest = c;
            }
             * */
             

        }

        
        
    }

}