//Write a program to convert binary numbers to their decimal representation.
//negative values are not covered - see ex 8

using System;
using System.Collections.Generic;

namespace BinaryToDecimal
{
    public class ConvertBinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary number :");
            string binaryNumber = Console.ReadLine();

            int decimalNumber = BinaryToDecimal(binaryNumber);

            Console.WriteLine("The decimal representation of {0} is {1}", binaryNumber, decimalNumber);

        }
        public static int BinaryToDecimal(string binaryString)
        {
            int sum = 0;
            for (int i = 0; i < binaryString.Length; i++)
                {
                    int element = ((int)Char.GetNumericValue(binaryString[i]) * System.Convert.ToInt32(Math.Pow(2, binaryString.Length - i - 1)));
                    sum = sum + element;
                }
                return sum;
         
        }
    }

}
