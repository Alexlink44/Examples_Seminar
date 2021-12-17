// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

int m = new Random().Next(4, 7);
int n = new Random().Next(4, 7);
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i + j + 2;
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}