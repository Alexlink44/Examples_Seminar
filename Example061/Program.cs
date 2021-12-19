// Найти произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixResult[i, j] = matrix1[i, k] * matrix2[k, j] + matrixResult[i, j];
            }
        }
    }
    return matrixResult;
}

int m = 2;
int n = 3;
int[,] matrix1 = Matrix(m, n);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = Matrix(n, m);
PrintMatrix(matrix2);
int[,] matrixResult = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrixResult);