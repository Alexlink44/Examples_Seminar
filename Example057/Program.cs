// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

int[,] NormalizeSrings(int[,] matrix)
{
    int temp = 0;
    int column = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < column; k++)
        {
            for (int j = 0; j < (column - 1); j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] NormalizeSringsV2(int[,] matrix)
{
    int temp = 0;
    int column = matrix.GetLength(1);
    int min = matrix[0, 0];
    int max = matrix[0, 0];
    int k = 0;
    int h = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        min = matrix[i, 0];
        max = matrix[i, 0];
        k = 0;
        h = column - 1;
        while (k < h)
        {
            min = matrix[i, 0 + k];
            max = matrix[i, 0 + k];
            for (int j = 1 + k; j < h; j++)
            {
                if (matrix[i, j] < min) {min = matrix[i, j];}
                if (matrix[i, j] > max) {max = matrix[i, j];}
            }
            temp = max;
            max = matrix[i, h];
            matrix[i, h] = temp;
            temp = min;
            min = matrix[i, k];
            matrix[i, k] = temp;
            k++;
            h--;
        }  
    }
    return matrix;
}

int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
// NormalizeSrings(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);
NormalizeSringsV2(matrix);
Console.WriteLine();
PrintMatrix(matrix);