//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 

//Example:
//ha    fifi    ho  hi
//for   ha      hi  xx
//xxx   ha      ha  xx   --> ha ha ha

//s     qq    s
//pp    pp    s 
//pp    qq    s --> s s s 

using System;

class SequenceOfEqualStrings
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix :");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m=");
        int m = int.Parse(Console.ReadLine());

        string [,] matrix = new string[n, m];

        //same column 
        //string[,] matrix={{"s","qq","s"},{"pp","pp","s"},{"p","qq","s"}};
        //same row
        //string[,] matrix = { { "s", "s", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "q" } };
        //same diagonal
        //string[,] matrix = { { "s", "qq", "p" }, { "pp", "s", "pp" }, { "qq", "p", "s" } };

        int countCol;
        int countRow;
        int countDiagonal;
        int maxCount = 0;
        int equalElementRow = 0;
        int equalElementCol = 0;

        ////read matrix
        Console.WriteLine("Enter matrix elements");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0},{1}]:", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        //print matrix

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,5}",matrix[i, j]);
            }
            Console.WriteLine();

        }

        //process the matrix
        //find equals elements on same row
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            countRow = 1;
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
               if (matrix[row, col] == matrix[row, col+1])
                {
                   countRow++;
                                       
                }
               
               if (countRow > maxCount)
               {
                   maxCount = countRow;
                   equalElementRow = row;
                   equalElementCol = col;

               }
            }
            
        }

        //find equals elements on same column
        for (int col = 0; col < matrix.GetLength(1) ; col++)
        {
            countCol = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    countCol++;

                }
                if (countCol > maxCount)
                {
                    maxCount = countCol;
                    equalElementRow = row;
                    equalElementCol = col;
                }
            }
            
        }

        //find equals elements on same diagonal
        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                countDiagonal = 1;
                while ((row+countDiagonal<matrix.GetLength(0))
                    && (col+countDiagonal<matrix.GetLength(1))
                    && (matrix[row, col] == matrix[row + countDiagonal, col + countDiagonal]))
                {
                    countDiagonal++;
                    if (countDiagonal > maxCount)
                    {
                        maxCount = countDiagonal;
                        equalElementRow = row;
                        equalElementCol = col;
                    }
                }
                
            }
            
        }
        

        //print results
        if (maxCount>1)
        {
            Console.Write("The longest sequence of equal string has {0} elements : ", maxCount);
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(matrix[equalElementRow, equalElementCol] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There's no equal strings in the matrix");
        }
        
    }
}
