//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.


using System;

class ExchangeBits345With242526Of32Unit
{
    static void Main()
    {
        uint number;
        uint actualBitValue3, actualBitValue4, actualBitValue5;
        uint actualBitValue24, actualBitValue25, actualBitValue26;
        uint modifiedNumber;
        
        Console.Write("Enter an integer number : ");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binar representation :{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
              
        //find the actual bit values at selected positions
        actualBitValue3 = (number & (1 << 3))>>3;
        actualBitValue4 = (number & (1 << 4))>>4;
        actualBitValue5 = (number & (1 << 5)) >> 5;
        actualBitValue24 = (number & (1 << 24)) >> 24;
        actualBitValue25 = (number & (1 << 25)) >> 25;
        actualBitValue26 = (number & (1 << 26)) >> 26;
        
        Console.WriteLine();

        //set the new values to the number
        
        //if the the actual bit is 1 we change it to 0, otherwise we change it to 1
        if (actualBitValue3 == 0)
        {
            modifiedNumber = number & ~(uint)(1 << 24);
        }
        else
        {
            modifiedNumber = number | (1 << 24);
        }
            
        if (actualBitValue4 == 0)
        {
            modifiedNumber = modifiedNumber & ~(uint)(1 << 25);
        }
        else
        {
            modifiedNumber = modifiedNumber | (1 << 25);
        }
        
        if (actualBitValue5 == 0) 
        {
            modifiedNumber = modifiedNumber & ~(uint)(1 << 26);
        }
        else 
        {
            modifiedNumber = modifiedNumber | (1 << 26);
        }
        
        if (actualBitValue24 == 0)
        {
            modifiedNumber = modifiedNumber & ~(uint)(1 << 3);
        }
        else
        {
            modifiedNumber = modifiedNumber | (1 << 3);
        }
        
        if (actualBitValue25 == 0)
        {
            modifiedNumber = modifiedNumber & ~(uint)(1 << 4);
        }
        else
        {
            modifiedNumber = modifiedNumber | (1 << 4);
        }
        
        if (actualBitValue26 == 0)
        {
            modifiedNumber = modifiedNumber & ~(uint)(1 << 5);
        }
        else
        {
            modifiedNumber = modifiedNumber | (1 << 5);
        }
        
        Console.WriteLine("The modified number is {0} :{1}", modifiedNumber, Convert.ToString(modifiedNumber, 2).PadLeft(32, '0'));       
    }
}

