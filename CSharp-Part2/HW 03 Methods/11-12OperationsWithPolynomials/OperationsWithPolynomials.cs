//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 -> 5 0 1
//
//Extend the program to support also subtraction and multiplication of polynomials.



using System;

class OperationsWithPolynomials
{
    static void Main()
    {
        int[] polynom1 = new int[3];
        int[] polynom2 = new int[3];
        int[] result;
        int option = 0;

        Random randomNumber = new Random();

        polynom1 = GenerateArray(polynom1, randomNumber);
        polynom2 = GenerateArray(polynom2, randomNumber);
        Console.WriteLine("The first polynomial is:");
        PrintArray(polynom1);
        Console.WriteLine("The second polynomial is:");
        PrintArray(polynom2);

        do
        {
            Console.WriteLine("Choose the math operation for the polynomials :\n 1. Adding\n 2. Substraction\n 3. Multipication ");
            option = int.Parse(Console.ReadLine());
        }
        while ((option != 1) && (option != 2) && (option != 3));
        if (option == 1)
        {
            result = SumOfPolynoms(polynom1, polynom2);
        }
        else if (option == 2)
        {
            result = SustractionOfPolynoms(polynom1, polynom2);
        }
        else
        {
            result = MultiplicationOfPolynoms(polynom1, polynom2);
        }

        Console.WriteLine("The new polynomial is:");
        PrintArray(result);
    }

    static int[] GenerateArray(int[] array, Random randomNumber)
    {
        //Random randomNumber = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(10);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        bool isFirstToPrint = true;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                if (!isFirstToPrint)
                {
                    Console.Write("+ ");
                }
                if (i == 0)
                {
                    Console.Write("{0}", array[i]);
                }
                else if (i == 1)
                {
                    Console.Write("{0}x ", array[i]);
                }
                else
                {
                    Console.Write("{0}x{1} ", array[i], i);
                }
                isFirstToPrint = false;
            }
            else if (array[i] < 0)
            {
                if (i == 0)
                {
                    Console.Write("- {0}", array[i]);
                }
                else if (i == 1)
                {
                    Console.Write("- {0}x ", array[i]);
                }
                else
                {
                    Console.Write("- {0}x{1} ", array[i], i);
                }
                isFirstToPrint = false;
            }
        }
        Console.WriteLine();
    }

    static int[] SumOfPolynoms(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    static int[] SustractionOfPolynoms(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] - array2[i];
        }

        return result;
    }

    static int[] MultiplicationOfPolynoms(int[] array1, int[] array2)
    {
        int[] result = new int[(2 * array1.Length) - 1];

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                result[j + i] = result[j + i] + (array1[i] * array2[j]);
            }
        }

        return result;
    }
}
