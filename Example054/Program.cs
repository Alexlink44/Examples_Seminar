// В матрице чисел найти сумму элементов главной диагонали.

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

void SumMainDiagonalV1(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    Console.WriteLine(sum);
}

void SumMainDiagonalV2(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int sum = 0;
    while (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        sum = sum + matrix[i, j];
        i++;
        j++;
    }
    Console.WriteLine(sum);
}


int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
SumMainDiagonalV1(matrix);
SumMainDiagonalV2(matrix);