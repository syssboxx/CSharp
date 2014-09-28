//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; 
//Three sides;
//Two sides and an angle between them. Use System.Math.


using System;

class CalculateTriangleSurface
{
    static double surface = 0;
    static void Main()
    {
        Console.WriteLine("Enter method for calculate the rectnagle's surface by :");
        Console.WriteLine("Choose 1 for Side and an altitude to it");
        Console.WriteLine("Choose 2 for Three sides");
        Console.WriteLine("Choose 3 for Two sides and an angle between them");
        int choice = int.Parse(Console.ReadLine());
        
        switch (choice)
        {
            case 1: 
                Console.Write("Enter side =");
                double baseSide = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude =");
                double altitude = double.Parse(Console.ReadLine());
                surface = CalculateSurfaceBySideAndAltitude(baseSide,altitude);
                break;

             case 2: 
                Console.Write("Enter side1 =");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side2 =");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter side3 =");
                double side3 = double.Parse(Console.ReadLine());
                surface = CalculateSurfaceByThreeSides(side1,side2,side3);
                break;

             case 3: 
                Console.Write("Enter side1 =");
                double firstSideNextToAngle = double.Parse(Console.ReadLine());
                Console.Write("Enter side2 =");
                double secondSideNextToAngle = double.Parse(Console.ReadLine());
                Console.Write("Enter angle between the two sides :");
                int angle = int.Parse(Console.ReadLine());
                surface = CalculateSurfaceByTwoSidesAndAngle(firstSideNextToAngle, secondSideNextToAngle,angle);
                break;

            default: Console.WriteLine("invalid choice");
                break;
        }
        if ((surface==0)||(surface<0))
        {
            Console.WriteLine("Invalid input. Sides must be positive and greater than 0"); 
        }
        else
        {
             Console.WriteLine("Surface : {0}", surface);
        }
        
    }
    static double CalculateSurfaceBySideAndAltitude(double a, double h)
    {
        if ((a!=0)||(h!=0))
        {
            surface = (a * h) / 2;
        }
        else
	    {
            surface =0;
	    }
        return surface;
    }

    static double CalculateSurfaceByThreeSides(double a, double b, double c)
    {
        double p = a + b + c;
        surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return surface;
    }

    static double CalculateSurfaceByTwoSidesAndAngle(double a, double b, int angle)
    {
        if ((a != 0) || (b != 0))
        {
            surface = (a * b * Math.Sin(angle)) / 2;
        }
        else
        {
            surface = 0;
        }
        return surface;
    }
}
