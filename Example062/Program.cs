// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

int[,] deleteRowAndColumn(int[,] matrix)
{
    int[] index = new int[2];
    int minNum = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNum) {minNum = matrix[i, j]; index[0] = i; index[1] = j;}
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, index[1]] = 0;
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[index[0], j] = 0;
    }
    return matrix;
}

int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
matrix = deleteRowAndColumn(matrix);
PrintMatrix(matrix);