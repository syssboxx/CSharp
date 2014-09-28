//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


using System;

    class GetMaxNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 integers :");
            Console.Write("number 1 =");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("number 2 =");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("number 3 =");
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(firstNumber, secondNumber); 
            maxNumber = GetMax(maxNumber, thirdNumber);

            Console.WriteLine("Maximal number is {0}",maxNumber);
        }

        static int GetMax(int number1, int number2)
        {
            int max = number1;

            if (number2 > max)
            {
                max = number2;
            }
            else max = number1;
            return max;
            
        }
    }
