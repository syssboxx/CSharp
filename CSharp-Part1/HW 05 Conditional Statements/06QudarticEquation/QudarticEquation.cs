//Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QudarticEquation
{
    static void Main()
    {
        double a, b, c;
        double discriminant;
        double sqrtDiscriminant;

        double x1, x2, x;

        Console.WriteLine("Let's solve a quadratic equation ax2+bx+c=0. Enter the coefficients : ");
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        discriminant = b * b - 4 * a * c;
        sqrtDiscriminant = Math.Sqrt(discriminant);

        x1 = (-b + sqrtDiscriminant) / (2 * a);
        x2 = (-b - sqrtDiscriminant) / (2 * a);
        x = -b / (2 * a);

        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic quation");
        }
        else 
        {
            if (sqrtDiscriminant > 0)
            {
                Console.WriteLine("The equation has 2 real roots : {0:F2} and {1:F2}", x1, x2);
            }
            else if (sqrtDiscriminant == 0)
            {
                Console.WriteLine("The equation has 1 real roots : {0:F2}", x);
            }
            else
            {
                Console.WriteLine("The equation hasn't 0 real roots. ");
            }
        }
      }
        
}
