//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.


using System;

class Program
{
    static void Main()
    {

        int start = 65; // A
        int end = 90;   //Z
        int length = end - start+1;
        int[] lettersCode = new int[length];

        char[] letters = new char[length];

        bool isFound = false;

        for (int i = start; i < end; i++)
        {
            lettersCode[i - start] = i;
        }
       
        //fill the array
        for (int i = start; i <= end; i++)
        {
            char ch = System.Convert.ToChar(i);
            letters[i-start] = ch;

        }
        //print CHAR array
        foreach (char letter in letters)
        {
          Console.Write(letter + " ");
        }
         Console.WriteLine();

        //print indexes
         for (int i = 0; i < letters.Length; i++)
         {
             Console.WriteLine("{0}->[{1}]",letters[i],i);
         }
        

         //print INT CODES array
         //foreach (int letter in letters)
         //{
         //    Console.Write((int)letter + " ");
         //}
         //Console.WriteLine();
        
        //char letter = 'a';//97
        //char letterz = 'z';//122

       Console.Write("Enter a word :");
       string word=Console.ReadLine();
       
       for (int i = 0; i <= word.Length-1; i++)
       {
           for (int j = 0; j < letters.Length; j++)
           {
               if (((int)word[i] >= 97) && ((int)word[i] <= 122)) //small letters
               {
                   word = word.ToUpper();
                   isFound = true;
                   Console.WriteLine("word[{0}]->{1}", word[i], j);
               }
               else if (((int)word[i] >= 65) && ((int)word[i] <= 90)) //big letters
               {
                   if ((int)word[i] == (int)letters[j])
                   {
                       isFound = true;
                       Console.WriteLine("word[{0}]->{1}", word[i], j);
                   } 
               }
               else
               {
                   Console.WriteLine("it's not a valid letter of the alphabet!");
               }
   
           }
       }
       

      
        
    }
}
