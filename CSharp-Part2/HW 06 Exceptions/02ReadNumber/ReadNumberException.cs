//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 

//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class ReadNumberException
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int num = 0;

        Console.WriteLine("Enter 10 numbers in the range ({0},{1})\nEach number must be bigger than previous :",start,end);

        try
        {
            for (int i = 0; i <10; i++)
            {
                num = ReadNumber(start, end);
                start = num;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number is out of range ({0},{1})",start,end);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too big for integer");
         }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null value");
        }

    }

    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a number :");
         int number = Int32.Parse(Console.ReadLine());
         if ((number <=start)||(number>=end))
	     {
           throw new System.ArgumentOutOfRangeException();
	     }
         return number;

    
    }
}
