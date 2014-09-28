//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a signed 16 bits number :");
        short signedNum = short.Parse(Console.ReadLine());

        List<int> remainders = new List<int>();

        StringBuilder binaryBuilder = new StringBuilder();
        string binaryNumber = "";

        if (signedNum > 0)
        {
            //calculate the remainders and put them in renversed order in a string
            remainders = ConvertToBinary(signedNum);

            for (int i = 0; i < remainders.Count; i++)
            {
                binaryBuilder.Append(remainders[i]);
            }
            binaryNumber = binaryBuilder.ToString();

            //binary representation - add zeros to fill the numbers of digits
            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber = "0" + binaryNumber;
            }

        }
        // negative number 
        else
        {
            //-a=~(a-1)
            //find the binaryNumber represenation pf a-1 and than reverse the bits with ~
            signedNum = (short)(Math.Abs(signedNum) - 1);

            remainders = ConvertToBinary(signedNum);

            //apply logical not ~
            for (int i = 0; i < remainders.Count; i++)
            {
                if (remainders[i] == 0)
                {
                    binaryNumber += "1";

                }
                else
                {
                    binaryNumber += "0";
                }
            }

            //binary representation - add 1 in the start
            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber = "1" + binaryNumber;
            }

        }

        Console.WriteLine("Binary represenation of {0} is {1}", signedNum, binaryNumber);

    }
    static List<int> ConvertToBinary(short number)
    {
        List<int> remainingList = new List<int>();

        while (number != 0)
        {
            remainingList.Add(number % 2);
            number = (short)(number / 2);
        }

        remainingList.Reverse();
        return remainingList;
    }

   
}