//Write a program to convert hexadecimal numbers to their decimal representation.

//TO TEST 
//FF - 255
//9786 = 38790
//ABCDEF= 11259375


using System;

class ConvertHexaToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number :");
        string hexaNum = Console.ReadLine();
        hexaNum=hexaNum.ToUpper();
        
        int decimalNum = HexaToDecimal(hexaNum);
        Console.WriteLine("The decimal representation of {0} is {1}", hexaNum, decimalNum);
    }
    public static int HexaToDecimal(string hexaStr)
    {
        int sum = 0;

       for (int i = 0; i < hexaStr.Length; i++)
        {
            int position = 0;
            if (((int)hexaStr[i] >= 65) && ((int)hexaStr[i] <= 70))
            {
                switch ((int)hexaStr[i])
                {
                    case 65: position = 10; break;
                    case 66: position = 11; break;
                    case 67: position = 12; break;
                    case 68: position = 13; break;
                    case 69: position = 14; break;
                    case 70: position = 15; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                position = (int)Char.GetNumericValue(hexaStr[i]);
            }
           
            int power=System.Convert.ToInt32(Math.Pow(16, hexaStr.Length - i - 1));
            int element = position * power ;
            sum = sum + element;
         }
        return sum;
    }
}