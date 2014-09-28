//Write a program that fills and prints a matrix of size (n, n) as shown below: 

//(examples for n = 4)

//1   5   9   13
//2   6   10  14
//3   7   11  15
//4   8   12  16

//1   8   9   16
//2   7   10  15
//3   6   11  14
//4   5   12  13

//7   11  14  16
//4   8   12  15
//2   5   9   13
//1   3   6   10


//1   12  11  10
//2   13  16  9
//3   14  15  8
//4   5   6   7



using System;

class PrintMatrix
{
     static void Main()
    {
        Console.Write("Enter array dimension : ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix= new int[n, n];

        //fill first matrix

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            matrix[row, 0] = row+1;
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
                matrix[row, col+1] = matrix[row, col] + matrix.GetLength(0);
                
              }
        }

         //print array
         PrintArray(matrix);

         Console.WriteLine();

        //fill second matrix
        int numberFill = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                //fill the odd columns 
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = numberFill;
                    numberFill++;
                }
            }
            else
            {
                //fill the even columns 
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = numberFill;
                    numberFill++;
                }
            }
        }

        //print array
        PrintArray(matrix);

        Console.WriteLine();

        //fill third matrix
        numberFill = 1;
        int maxElements = 0;
        int positionRow = 0;
        int positionCol = 0;

        for (int diagonal = 0; diagonal < (2*matrix.GetLength(1) - 1); diagonal++)
        {
            if (diagonal < matrix.GetLength(1))
            {
                maxElements++;
                positionRow = matrix.GetLength(1) - diagonal - 1;
                positionCol = 0;
            }
            else
            {
                maxElements--;
                positionRow = 0;
                positionCol = diagonal - matrix.GetLength(1) +1;
            }

            for (int element = 0; element < maxElements; element++)
            {
                matrix[positionRow, positionCol] = numberFill;
                numberFill++;
                positionRow++;
                positionCol++;
            }
            
        }

        //print array
        PrintArray(matrix);

        Console.WriteLine();

        //fill fourth matrix
        // the first and the last element of every iteration and direction change over the matrix 
        int start = 0;
        int end = n;
        numberFill = 1;

        while (end-start>0)
        {
            //direction down - indexes 0-4 / elements 1-5
            for (int down = start; down < end; down++)
            {
                matrix[down, start] = numberFill;
                numberFill++;
            }
            //direction right - indexes 1-4 / elements 6-9
            for (int right = start+1; right < end; right++)
            {
                matrix[end-1,right]=numberFill;
                numberFill++;
            }
            //direction up - indexes 3-0 / elements 10-13
            for (int up = end-2; up >= start; up--)
            {
                matrix[up, end - 1] = numberFill;
                numberFill++;
            }
            //direction left - indexes 3-1 / elements 14-16
            for (int left = end-2; left >=start+1; left--)
            {
                matrix[start,left]=numberFill;
                numberFill++;

            }
            //change first and last element for the inner direction change
            start++;
            end--;
        }
        


        //print array
        PrintArray(matrix);

    }

     private static void PrintArray(int[,] matrix)
     {
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
             for (int j = 0; j < matrix.GetLength(1); j++)
             {
                 Console.Write("{0,5}", matrix[i, j]);
             }
             Console.WriteLine();
         }
     }
}
