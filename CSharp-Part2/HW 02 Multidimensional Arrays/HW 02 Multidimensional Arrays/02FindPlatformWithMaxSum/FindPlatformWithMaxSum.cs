//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
//that has maximal sum of its elements.


using System;

class FindPlatformWithMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix : (n!=m)");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m=");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        int platform = 3;

        int sum = 0;
        int bestSum = int.MinValue;

        int startRow = 0;
        int startCol = 0;
        
        int bestStartRow = 0;
        int bestStartCol = 0;

        if ((n < platform) || (m < platform))
        {
            Console.WriteLine("Invalid input. The size of the matrix has to be bigger than the searched platform!");
        }
        else
        {
            //generate random values for matrix elements
            Random generator = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = generator.Next(-10, 11);
                }
            }

            //print matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            //find platform 3x3 with maximal sum
            for (int row = 0; row < matrix.GetLength(0) - platform+1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - platform+1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    startRow = row;
                    startCol = col;
                 }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestStartRow = startRow;
                    bestStartCol = startCol;
                }
            }

            if ((n == 3) && (m == 3))
            {
                Console.WriteLine("There's only one sum in the platform 3x3 : {0}",bestSum);
            }
            else
            {
                //print maximal sum and platform 
                Console.WriteLine("The maximal sum is {0}.\nMaximal platform :", bestSum);

                for (int i = bestStartRow; i <= bestStartRow + platform - 1; i++)
                {
                    for (int j = bestStartCol; j <= bestStartCol + platform - 1; j++)
                    {
                        Console.Write("{0,3}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            

        }
        
    }
}
