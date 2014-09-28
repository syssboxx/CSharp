//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PrintPerimeterAreaOfCircle
{
    static void Main()
    {
        double permiter;
        double area;
        double pi = Math.PI;
        Console.Write("Enter the radius of the circle : ");
        double radius = double.Parse(Console.ReadLine());

        //permimeter=2*Pi*r, area=Pi*r^2
        permiter = 2 * pi * radius;
        area = pi * radius * radius;

        Console.WriteLine("The perimeter is {0:F2}",permiter);
        Console.WriteLine("The area is {0:F2}",area);

    }
}
