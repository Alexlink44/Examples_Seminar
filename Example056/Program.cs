// Написать программу, которая обменивает элементы первой строки и последней строки.

int[,] Matrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] StringSwap(int[,] matrix)
{
    int first = 0;
    int last = (matrix.GetLength(0) - 1);
    int tempNumber = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tempNumber = matrix[first, i];
        matrix[first, i] = matrix[last, i];
        matrix[last, i] = tempNumber;
    }
    return matrix;
}


int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
matrix = StringSwap(matrix);
PrintMatrix(matrix);