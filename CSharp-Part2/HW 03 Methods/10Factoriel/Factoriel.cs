//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


using System;

class Factoriel
{
    static void Main()
    {
        byte[] factoriel = { 1 };

        for (int i = 1; i < 10; i++)
        {
            factoriel = CalculeFactoriel(factoriel, i);

            Console.WriteLine("The factoriel of {0} is:", i);
            PrintArray(factoriel);
            Console.WriteLine();
            //PrintNumber(factorial = Multiply(factorial, i));
        }
    }

    static void PrintArray(byte[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static byte[] CalculeFactoriel(byte[] array, int multiplayer)
    {
        byte[] result = { 0 };

        for (int i = 0; i < multiplayer; i++)
        {
            result = CalculateSum(result, array);
        }

        return result;
    }


    static byte[] CalculateSum(byte[] array1, byte[] array2)
    {
        //in case of array2 is bigger than array1
        if (array1.Length > array2.Length)
        {
            return CalculateSum(array2, array1);
        }

        byte[] result = new byte[array2.Length + 1];

        int i = 0;
        int res = 0;

        for (; i < array1.Length; i++)
        {
            result[i] = (byte)(array1[i] + array2[i] + res);

            res = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < array2.Length && res != 0; i++)
        {
            result[i] = (byte)(array2[i] + res);

            res = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < array2.Length; i++)
        {
            result[i] = array2[i];
        }

        if (res != 0)
        {
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1);
        }

        return result;
    }
}
