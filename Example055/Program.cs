// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void AverageColumns(int[,] matrix)
{   
    double result = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result = result + matrix[j, i];
        }
        result = result / (matrix.GetLength(0));
        Console.WriteLine($"Ср. ар. {i + 1}-го столбца = {result}");
    }
}

int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
AverageColumns(matrix);