//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


using System;

class ExchangeMultipleBitsOfInteger
{
    static void Main()
    {
        uint number;
        uint resultNumber;

        int k;
        int p;
        int q;
        
        int[] numberArray = new int[32];
                
        Console.Write("Enter an integer number : ");
        number = uint.Parse(Console.ReadLine());

        Console.Write("Enter a number of bits to change k : ");
        k = int.Parse(Console.ReadLine());
        
        Console.Write("Enter a start position of first sequence p : ");
        p = int.Parse(Console.ReadLine());

        Console.Write("Enter a start position of second sequence q : ");
        q = int.Parse(Console.ReadLine());

        Console.WriteLine("Binar representation :{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        resultNumber = number;

        //get bit value and add it to array's elements
        for (int i = 0; i < 32; i++)
        {
            numberArray[i] = (int)((number & (1 << i)) >> i);
        }

        //exchangenge bits (array elements) with XOR
        for (int i = 0; i < k; i++)
        {
            numberArray[p + i] = numberArray[p + i] ^ numberArray[q + i];
            numberArray[q + i] = numberArray[q + i] ^ numberArray[p + i];
            numberArray[p + i] = numberArray[p + i] ^ numberArray[q + i];

        }

        //Compose new number from array of bits
        for (int i = 0; i < 32; i++)
        {
            if (numberArray[i] == 0)
            {
                resultNumber = (resultNumber & ~(uint)(1 << i)); //set the bit to 0
            }
            else
            {
                resultNumber = (resultNumber | (uint)(1 << i)); //set the bit to 1
            }
        }

        Console.WriteLine("The modified number is {0} :{1}", resultNumber, Convert.ToString(resultNumber, 2).PadLeft(32, '0'));
    }
}