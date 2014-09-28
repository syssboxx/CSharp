//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;


    class ConvertDecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number :");
            int decimalNum=int.Parse(Console.ReadLine());

            StringBuilder hexaNum = new StringBuilder();

            //append all the remainders in the string builder
            while (decimalNum>0)
            {
                switch (decimalNum%16)
                {
                    case 10: hexaNum.Append('A'); break;
                    case 11: hexaNum.Append('B'); break;
                    case 12: hexaNum.Append('C'); break;
                    case 13: hexaNum.Append('D'); break;
                    case 14: hexaNum.Append('E'); break;
                    case 15: hexaNum.Append('F'); break;
                    default: hexaNum.Append(decimalNum % 16);break;
                }
                decimalNum = decimalNum / 16;
             }
            string hexaResult = hexaNum.ToString();
           Console.Write("The hexadecimal representation is ");

            //print in reverse order
            for (int i = hexaResult.Length-1; i >=0; i--)
            {
                Console.Write(hexaResult[i]);
            }
            Console.WriteLine();
        }

        
    }
    
