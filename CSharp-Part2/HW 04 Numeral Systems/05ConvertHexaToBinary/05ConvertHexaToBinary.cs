//Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number :");
        string hexaNum = Console.ReadLine();
        hexaNum = hexaNum.ToUpper();

        string binaryNum = HexaToBinary(hexaNum);
        Console.WriteLine("The binary representation of {0} is {1}", hexaNum, binaryNum);
    }

    static string HexaToBinary(string hexaStr)
    {
        string binaryStr = "";
        StringBuilder binary = new StringBuilder();

        //read the hexaNumber as string and take each separe value
        //change every hexa digit with the corresponding binary sequence and an separating empty interval for better representation

        for (int i = 0; i < hexaStr.Length; i++)
        {
            switch (hexaStr[i])
            {
                case '0': binary.Append("0000").Append(" "); break;
                case '1': binary.Append("0001").Append(" "); break;
                case '2': binary.Append("0010").Append(" "); break;
                case '3': binary.Append("0011").Append(" "); break;
                case '4': binary.Append("0100").Append(" "); break;
                case '5': binary.Append("0101").Append(" "); break;
                case '6': binary.Append("0110").Append(" "); break;
                case '7': binary.Append("0111").Append(" "); break;
                case '8': binary.Append("1000").Append(" "); break;
                case '9': binary.Append("1001").Append(" "); break;
                case 'A': binary.Append("1010").Append(" "); break;
                case 'B': binary.Append("1011").Append(" "); break;
                case 'C': binary.Append("1100").Append(" "); break;
                case 'D': binary.Append("1101").Append(" "); break;
                case 'E': binary.Append("1110").Append(" "); break;
                case 'F': binary.Append("1111").Append(" "); break;
                default: binary.Append(""); break;
            }
         }
          
        binaryStr=binary.ToString();
        return binaryStr;
    }
}