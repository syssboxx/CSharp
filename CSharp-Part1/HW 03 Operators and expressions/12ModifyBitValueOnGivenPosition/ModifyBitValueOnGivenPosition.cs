//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p 
//from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ModifyBitValueOnGivenPosition
{
    static void Main()
    {
        int number;
        int position;
        int mask;
        int newBitValue;
        int actualBitValue;
        int modifiedNumber;
        int inversedMask;


        Console.Write("Enter an integer number : ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binar representation :{0}", Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.Write("Enter the bit's position to change : ");
        position = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter the bit's value to set (0 or 1) : ");
            newBitValue = byte.Parse(Console.ReadLine());
        }
        while ((newBitValue != 0) && (newBitValue != 1));
        
        //find the actual bit value
        mask = 1 << position;
        int nAndMask =mask & number;
        actualBitValue = nAndMask >> position;

        Console.WriteLine();
        Console.WriteLine("The actual bit value at positon {0} is {1}",position,actualBitValue);
        Console.WriteLine();

        //check if the actual bit value and the bit value are the same 
        if (actualBitValue == newBitValue)
        {
            Console.WriteLine("The bit value is the same. The number is not modified : {0}", Convert.ToString(number, 2).PadLeft(8, '0'));
        }
        else
        {
            //change the actual bit to 0
            if (actualBitValue == 1)
            {

                Console.WriteLine("The bit at position {0} is set to {1}", position, actualBitValue);
                inversedMask = ~mask;
                modifiedNumber = number & inversedMask;
                Console.WriteLine("The modified number is {0} :{1}", modifiedNumber, Convert.ToString(modifiedNumber, 2).PadLeft(8, '0'));

            }
            else if (actualBitValue == 0)   //change the actual bit to 1
            {
                Console.WriteLine("The bit at position {0} is set to {1}", position, actualBitValue);
                modifiedNumber = number | mask;
                Console.WriteLine("The modified number is {0} :{1}", modifiedNumber, Convert.ToString(modifiedNumber, 2).PadLeft(8, '0'));

            }
        }

        
    }
}