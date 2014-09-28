/* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
		
Example for N = 4
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 
*/

using System;

class PrintSpiral
{
    static void Main()
    {
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        int row = 0;
        int col=-1;
        int[,] matrix =new int[n,n];
        int numberToFill = 1;

        
        //fill the matrix
        //we have 1 loop (0,n) for each iteration with a choisen direction - left or right and another to process the elements (0,2(n-1)-1) : 
        //for n=4 : we have 7 5 3 1 elements

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < (2*(n-i)-1); j++)
            {
                //if the index is even - direction right and down - incrementation
               if (i%2==0)
	            {
		            if (j<n-i)
	                {
		                col++;
	                }
                    else
                    {
                        row++;
                    }
	            }
               else // if the index is odd - direction left and up - decrementation
               {
                    if (j<n-i)
	                {
		                col--;
	                }
                    else
                    {
                        row--;
                    }
               }
               matrix[row, col] = numberToFill;
               numberToFill++;
            }
        }

        //print the matrix
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0}\t",matrix[r,c]);
            }
            Console.WriteLine();
        }
    }
}
