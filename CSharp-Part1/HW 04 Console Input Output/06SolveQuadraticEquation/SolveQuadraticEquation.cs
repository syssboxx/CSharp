//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
//x2+2x-2=0 -> 2 real roots
//
using System;

class SolveQuadraticEquation
{
    static void Main()
    {
        double a,b,c;
        double discriminant;
        double sqrtDiscriminant;

        double realRoot1, realRoot2;

        Console.WriteLine("Let's solve a quadratic equation ax2+bx+c=0. Enter the coefficients : ");
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        discriminant = b * b - (4 * a * c);
        sqrtDiscriminant = Math.Sqrt(discriminant);

        realRoot1 = (-b + sqrtDiscriminant) / (2 * a);
        realRoot2 = (-b - sqrtDiscriminant) / (2 * a);

        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic quation");
        }
        else
        {
            if (sqrtDiscriminant > 0)
            {
                Console.WriteLine("The equation has 2 real roots - {0:F2} and {1:F2}", realRoot1, realRoot2);
            }
            else if (sqrtDiscriminant == 0)
            {
                Console.WriteLine("The equation has 1 real roots - {0:F2}", realRoot1);
            }
            else
            {
                Console.WriteLine("The equation hasn't real solution (0 real roots) ");
            }
        }

       
    }
}
