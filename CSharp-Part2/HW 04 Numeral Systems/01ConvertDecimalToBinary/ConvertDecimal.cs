//Write a program to convert decimal numbers to their binary representation.
//500d = 111110100b


using System;
using System.Collections.Generic;

namespace ConvertDecimalToBinary
{

    public class ConvertDecimal
    {
        public static void Main()
        {
            Console.WriteLine("Enter a decimal number :");
            int decimalNumber = int.Parse(Console.ReadLine());

            List <byte> binaryDigits = new List <byte>();

            binaryDigits = DecimalToBinary(decimalNumber);
            PrintBinaryPresentation(binaryDigits);

        }

        public static List<byte> DecimalToBinary(int number)
        {
            List<byte> binarySequence = new List<byte>();
           
            while (number>0)
            {
                binarySequence.Add((byte)(number % 2));
                number = number / 2;
            }
            binarySequence.Reverse();

            return binarySequence;
           
        }

        public static void PrintBinaryPresentation(List<byte> sequence)
        {

            for (int i = 0; i <sequence.Count; i++)
            {
                Console.Write(sequence[i]+" ");
            }

            Console.WriteLine();
        }
    }
}
