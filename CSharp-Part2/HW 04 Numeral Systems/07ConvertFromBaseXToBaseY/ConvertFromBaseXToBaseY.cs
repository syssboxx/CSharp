using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertFromBaseXToBaseY
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter initial base (base >=2) :");
        int initialBase = int.Parse(Console.ReadLine());

        //the number to convert
        Console.WriteLine("Enter number in base {0}", initialBase);
        string input = Console.ReadLine();

        Console.WriteLine("Enter converted base (base <=16) :");
        int convertedBase = int.Parse(Console.ReadLine()); ;

        int numberToDec = ConvertToDec(input, initialBase);
        string numberToBase = FromDecToBase(numberToDec, convertedBase);

        Console.WriteLine("The presentation of {0} ({1}) is {2} ({3})", input, initialBase, numberToBase, convertedBase);
    }

    static int ConvertToDec(string inputStr, int inputBase)
    {
        int sum = 0;
        for (int i = 0; i < inputStr.Length; i++)
        {
            int position = (int)inputStr[i] - '0';
            int power = System.Convert.ToInt32(Math.Pow(inputBase, inputStr.Length - i - 1));

            if (Char.IsLetter(inputStr[i]) == false)
            {

                int element = position * power;
                sum = sum + element;
            }
            else
            {
                int letterToNum = (int)inputStr[i] - 55;
                int element = letterToNum * power;
                sum = sum + element;
            }

        }
        return sum;

    }

    static string FromDecToBase(int decimalNum, int outputBase)
    {

        string result = "";
        string reversedResult = "";
        while (decimalNum > 0)
        {
            result += decimalNum % outputBase;
            decimalNum /= outputBase;
        }
        //reverse the sequence
        for (int i = result.Length - 1; i >= 0; i--)
        {
            reversedResult += result[i];
        }

        return reversedResult;

    }
}
