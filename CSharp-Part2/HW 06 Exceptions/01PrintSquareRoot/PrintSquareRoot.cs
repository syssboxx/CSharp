//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number".
//In all cases finally print "Good bye". Use try-catch-finally.


using System;

class PrintSquareRoot
{
    static void Main()
    {
        CalculateSquareRoot();
    }

    static void CalculateSquareRoot()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            Console.WriteLine(Math.Sqrt(number));
            return; 
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }

 }
