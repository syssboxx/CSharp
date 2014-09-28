//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class CheckSumSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integer numbers : (on separate lines");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        //total - 26 combinations 
        //sum of 5 elements is 0
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3},{4} elements is 0", a, b, c, d, e);
        }
        //sum of 4 elements is 0 - 5 combinations
        else if (a + b + c + d == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3} elements is 0", a, b, c, d);
        }
        else if (a + b + c + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3} elements is 0", a, b, c, e);
        }
        else if (a + c + d + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3} elements is 0", a, c, d, e);
        }
        else if (a + b + d + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3} elements is 0", a, b, d, e);
        }
        else if (b + c + d + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2},{3} elements is 0", b, c, d, e);
        }
        //sum of 3 elements - 10 combinations
        else if (a + b + c == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", a, b, c);
        }
        else if (a + b + d == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", a, b, d);
        }
        else if (a + b + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", a, b, e);
        }
        else if (c + b + d == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", b, c, d);
        }
        else if (b + c + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", b, c, e);
        }
        else if (a + c + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", a, c, e);
        }
        else if (c + d + e == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", e, c, d);
        }
        else if (c + d + a == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", c, d, a);
        }
        else if (d + e + b == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", d, e, b);
        }
        else if (a + e + d == 0)
        {
            Console.WriteLine("The subset of {0},{1},{2} elements is 0", a, e, d);
        }
        //sum of 2 elements=0 - 10 combinations
        else if (a + b == 0)
        {
            ;
            Console.WriteLine("The subset of {0},{1} elements is 0", a, b);
        }
        else if (a + c == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", a, c);
        }
        else if (a + d == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", a, d);
        }
        else if (a + e == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", a, e);
        }
        else if (c + b == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", c, b);
        }
        else if (d + b == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", d, b);
        }
        else if (e + b == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", e, b);
        }
        else if (c + d == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", c, d);
        }
        else if (c + e == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", c, e);
        }
        else if (e + d == 0)
        {
            Console.WriteLine("The subset of {0},{1} elements is 0", e, d);
        }
        


	}
}