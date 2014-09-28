//Write an expression that calculates rectangle’s area by given width and height.

using System;

class CalculateRectanglesArea
{
    static void Main()
    {
        float width;
        float height;
        Console.WriteLine("Enter rectangle's width : ");
        width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle's height : ");
        height = float.Parse(Console.ReadLine());
        float area = width * height;
        Console.WriteLine("The rectangle's area is {0}", area);
    }
}
