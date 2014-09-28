//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table
//of characters on the console.


using System;

    class PrintAsciiTable
    {
        static void Main()
        {
            //print the extended ASCII table - 255 symbols
            for (short i = 0; i < 256; i++)
            {
                short symbolNumber = i;
                char symbolAsciiCode=(char)i;
                Console.WriteLine("ASCII code {0} : {1}", symbolNumber,symbolAsciiCode);
            }
        }
    }

