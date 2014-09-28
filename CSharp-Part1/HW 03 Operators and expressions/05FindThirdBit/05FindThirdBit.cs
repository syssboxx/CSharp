//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

    class Program
    {
        static void Main()
        {
            int number,mask;
            int position=3;
            bool ifBitIs1;

            Console.Write("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of {0} : {1}",number,Convert.ToString(number,2).PadLeft(8,'0') );
            mask = 1 << position;

            //logical & applied to find if the value ot the bit at selected position is 0 or 1
            ifBitIs1 = (((mask & number) >> position) == 1);
            if (ifBitIs1)
            {
                Console.WriteLine("the bit 3 is 1");
            }
            else
            {
                Console.WriteLine("the bit 3 is 0");
            }
            
            //second way to print 
            Console.WriteLine("The bit at position {0} is {1}",position,(ifBitIs1?1:0));
        }
    }
