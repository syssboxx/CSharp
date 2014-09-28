//Write a program to convert binary numbers to hexadecimal numbers (directly).

//TO TEST
// 0011 1101 - > 0X3 0XD
using System;
using System.Text;

class ConvertBinaryToHex
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number");
        string binaryStr=Console.ReadLine();

        //check if the digit are less than multiplier by 4 and add leading zeros
        binaryStr=CheckLeadingZeros(binaryStr);

        string hexaStr = BinToHexa(binaryStr);
        Console.WriteLine("The hexadecimal representation of {0} is 0x{1}", binaryStr, hexaStr);
     }
    
    static string CheckLeadingZeros(string binary)
    {
        string result = "";
        if (binary.Length % 4 != 0)
        {
            result = new String('0', 4 - binary.Length % 4) + binary;
        }
        return result;
    }

    static string BinToHexa(string binary)
    {

        StringBuilder hexBuilder = new StringBuilder();
        string hexaResult = "";
        string bitSequence="";

        for (int i = 0; i < binary.Length; i+=4)
        {
            bitSequence = binary.Substring(i, 4);
            switch (bitSequence)
            {
                case "0000": hexBuilder.Append("0"); break;
                case "0001": hexBuilder.Append("1"); break;
                case "0010": hexBuilder.Append("2"); break;
                case "0011": hexBuilder.Append("3"); break;
                case "0100": hexBuilder.Append("4"); break;
                case "0101": hexBuilder.Append("5"); break;
                case "0110": hexBuilder.Append("6"); break;
                case "0111": hexBuilder.Append("7"); break;
                case "1000": hexBuilder.Append("8"); break;
                case "1001": hexBuilder.Append("9"); break;
                case "1010": hexBuilder.Append("A"); break;
                case "1011": hexBuilder.Append("B"); break;
                case "1100": hexBuilder.Append("C"); break;
                case "1101": hexBuilder.Append("D"); break;
                case "1110": hexBuilder.Append("E"); break;
                case "1111": hexBuilder.Append("F"); break;
                default: hexBuilder.Append("");break;
            }
        }
        hexaResult = hexBuilder.ToString();

        return hexaResult;
    }
}
