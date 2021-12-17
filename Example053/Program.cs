// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

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

void FindNumber(int[,] matrix, int number)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Позиция искомого числа: [{j + 1}, {i + 1}]");
                k++;
            }
            if (k == 1) break;
        }
        if (k == 1) break;
    }
    if (k != 1) {Console.WriteLine("Искомое число не найдено");}
}

int[,] matrix = Matrix(5, 6);
PrintMatrix(matrix);

Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
FindNumber(matrix, number);
