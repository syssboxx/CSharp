//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


using System;

class CheckIfPointWithinCircle
{
    static void Main()
    {
        float pointX;
        float pointY;
        float circleRadius = 5;
        float circleCenterX;
        float circleCenterY;

        Console.Write("Enter point's coordinate x=");
        pointX = float.Parse(Console.ReadLine());
        Console.Write("Enter point's coordinate y=");
        pointY = float.Parse(Console.ReadLine());
        Console.Write("Enter coordinates of the circle's center:\nx=");
        circleCenterX = float.Parse(Console.ReadLine());
        Console.Write("y=");
        circleCenterY = float.Parse(Console.ReadLine());

        //the point must satisfy the equation (X-centerx)^2+(Y-centery)^2=radius^2 to lie on the circle
        double result=Math.Pow((pointX-circleCenterX),2)+Math.Pow((pointY-circleCenterY),2);
        if (result < Math.Pow(circleRadius, 2))
        {
            Console.WriteLine("The point ({0},{1}) is inside the circle",pointX,pointY);
        }
        else if (result > Math.Pow(circleRadius, 2))
        {
            Console.WriteLine("The point ({0},{1}) is outside the circle", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) lies on the circle", pointX, pointY);
        }
    }
}