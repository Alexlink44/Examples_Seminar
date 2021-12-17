// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] Matrix(int n, int k)
{
    int[,] matrix = new int[n, k];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
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

int[,] ReverseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i + j) % 2 == 0) {matrix[i, j] = matrix[i, j] * (-1);}
        }
    }
    return matrix;
}





int n = new Random().Next(3, 6);
int k = new Random().Next(3, 6);

int[,] matrix = Matrix(n, k);
PrintMatrix(matrix);
matrix = ReverseMatrix(matrix);
PrintMatrix(matrix);