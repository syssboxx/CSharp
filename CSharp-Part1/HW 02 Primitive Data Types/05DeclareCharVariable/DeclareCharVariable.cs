//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class Program
{
    static void Main()
    {
        //hexadecimal representation of 72
        //char character = '\u0048';
        int hexCode = 0x48;
        char character = (char)hexCode;
        Console.WriteLine(character);
    }
}

