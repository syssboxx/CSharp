using System;


class Matrix
{
    public int Rows, Cols;
    private int[,] matrix;

    // Constructor
    public Matrix(int dim1, int dim2)
    {
        matrix = new int[dim1, dim2];
        Rows = dim1;
        Cols = dim2;
    }

    // Getter/Setter
    public int this[int dim1, int dim2]
    {
        get { return matrix[dim1, dim2]; }
        set { matrix[dim1, dim2] = value; }
    }

    // Addition
    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix1.Cols);

        for (int row = 0; row < resultMatrix.Rows; row++)
            for (int col = 0; col < resultMatrix.Cols; col++)
                resultMatrix[row, col] = matrix1[row, col] + matrix2[row, col];

        return resultMatrix;
    }

    // Subtraction
    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix1.Cols);

        for (int row = 0; row < resultMatrix.Rows; row++)
            for (int col = 0; col < resultMatrix.Cols; col++)
                resultMatrix[row, col] = matrix1[row, col] - matrix2[row, col];

        return resultMatrix;
    }

    // Naive multiplication
    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix1.Cols);

        for (int row = 0; row < resultMatrix.Rows; row++)
            for (int col = 0; col < resultMatrix.Cols; col++)
                for (int k = 0; k < matrix1.Cols; k++)
                    resultMatrix[row, col] += matrix1[row, k] * matrix2[k, col];

        return resultMatrix;
    }

    // Print
    public override string ToString()
    {
        int max = this.matrix[0, 0];
        foreach (int cell in this.matrix) max = Math.Max(max, cell);
        int cellSize = Convert.ToString(max).Length;

        string s = String.Empty;

        for (int row = 0; row < this.Rows; row++)
            for (int col = 0; col < this.Cols; col++)
                s += (Convert.ToString(this.matrix[row, col]).PadRight(cellSize, ' ') + (col != this.Cols - 1 ? " " : "\n"));

        return s;
    }
}

class CLassMatrix
{
    static void Main()
    {
        Console.Write("enter dimension n=");
        int n = int.Parse(Console.ReadLine());
        Matrix matrix1 = new Matrix(n, n);
        Matrix matrix2 = new Matrix(n, n);

        // Fill with random numbers
        Random randomGenerator = new Random();
        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int col = 0; col < matrix2.Cols; col++)
            {
                matrix1[row, col] = randomGenerator.Next(0,11);
                matrix2[row, col] = randomGenerator.Next(0,11);
            }
        }

        Console.WriteLine("Matrix 1");
        Console.WriteLine(matrix1);

        Console.WriteLine("Matrix 2");
        Console.WriteLine(matrix2);

        Console.WriteLine("Addition : Matrix 1 + Matrix 2");
        Console.WriteLine(matrix1 + matrix2);

        Console.WriteLine("Substraction : Matrix 1 - Matrix 2");
        Console.WriteLine(matrix1 - matrix2);

        Console.WriteLine("Multiplication : Matrix 1 * Matrix 2");
        Console.WriteLine(matrix1 * matrix2);
    }
}

