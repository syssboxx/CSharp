//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, 
//try to add some values or the null literal to them and see the result.


using System;

class AssignNullValues
{
    static void Main()
    {
        int? nullableInteger = null; 
        double? nullableDouble = null;
        Console.WriteLine("nullableInteger:{0}",nullableInteger);
        Console.WriteLine("nullableDouble:{0}",nullableDouble);
        nullableInteger = 5;
        nullableDouble = 5.87900;
        Console.WriteLine("nullableInteger:{0}", nullableInteger.Value);
        Console.WriteLine("nullableDouble:{0}", nullableDouble.Value);
        
     }
}