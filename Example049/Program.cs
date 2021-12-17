// Показать двумерный массив размером m×n заполненный вещественными числами

int m = 5;
int n = 5;
double[,] matrix = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        double number = new Random().Next(-100, 100);
        matrix[i, j] = number / 5;
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}