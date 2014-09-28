//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;

class PrintIsocelesTraingle
{
    static void Main()
    {
       Console.OutputEncoding = System.Text.Encoding.UTF8;
       char copyright='\u00A9';
       int numberRows = 3;
       
       Console.WriteLine();

       for (int rows = 0; rows < numberRows; rows++)
       {
           for (int spaceCounter = numberRows-rows-1; spaceCounter>=0; spaceCounter--)
           {
               Console.Write(" ");
           }
           for (int elementsCounter = 0; elementsCounter <= (2 * rows); elementsCounter++)
           {
               Console.Write(copyright);
           }
           Console.WriteLine();

       }

       Console.WriteLine();
    }
}