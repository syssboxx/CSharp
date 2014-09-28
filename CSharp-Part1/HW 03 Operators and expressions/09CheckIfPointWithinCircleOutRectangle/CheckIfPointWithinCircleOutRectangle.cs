//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckIfPointWithinCircleOutRectangle
{
    static void Main()
    {
        float pointX;
        float pointY;
        float circleRadius = 3;
        float circleCenterX=1;
        float circleCenterY=1;
        
        //I assume that top left coordinate of the rectangle is (1,-1)
        //float rectanglePointUpLeftX = 1;
        //float rectanglePointUpLeftY = -1;
        bool withinCircle;
        bool outOfRectangle=false;

        Console.Write("Enter point's coordinate x=");
        pointX = float.Parse(Console.ReadLine());
        Console.Write("Enter point's coordinate y=");
        pointY = float.Parse(Console.ReadLine());
        
        //check if the point is within the circle
        double result = Math.Pow((pointX - circleCenterX), 2) + Math.Pow((pointY - circleCenterY), 2);
        withinCircle = result <= Math.Pow(circleRadius, 2);
               
        //check if the point is out of the rectangle (the point must be outside of all sides of the rectangle)
        outOfRectangle =!(((pointX>=-1)&&(pointX<=5))&&((pointY>=-1)&&(pointY<1)));
        
        Console.WriteLine("The point is {0} and {1}",withinCircle?"inside the circle":"outside of the circle",outOfRectangle?"outside of the rectangle":"inside the rectangle");
    }
}

//trqbva da se proveri