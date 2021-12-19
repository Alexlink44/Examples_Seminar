// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void FindStrMinSumElements(int[,] matrix)
{
    int min = 0;
    int temp = 0;
    int str = 0;
    int numStr = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = temp + matrix[i, j];
        }
        if (i == 0) {str = temp;}
        else 
        {
            if (temp < str) {str = temp; numStr = i + 1;}
        }
    }
    Console.WriteLine($"{numStr}-я строка с наименьшей суммой элементов.");
}



int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
FindStrMinSumElements(matrix);