// Показать двумерный массив размером m×n заполненный целыми числами.
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}