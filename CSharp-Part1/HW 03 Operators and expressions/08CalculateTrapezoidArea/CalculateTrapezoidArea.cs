//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//area= (a+b).h/2

using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        float a;
        float b;
        float height;
        float area;

        Console.WriteLine("Enter upper side a = ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter lower side b = ");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h=");
        height = float.Parse(Console.ReadLine());
        area = ((a + b) * height) / 2;
        Console.WriteLine("The trapezoid' s area is {0}", area);

    }
}
