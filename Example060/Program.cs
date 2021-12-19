// Составить частотный словарь элементов двумерного массива.

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

void freqDictionary (int[,] matrix)
{
    var symbol = new List<int>();
    var symbolAmount = new List<int>();
    symbol.Add(Convert.ToInt32(matrix[0, 0]));
    symbolAmount.Add(1);
    int l = 1;
    int length = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            length = l;
            for (int s = 0; s < length; s++)
            {
                if (matrix[i, j] == symbol[s])
                {
                    symbolAmount[s] = symbolAmount[s] + 1;
                    length--;
                }
            }
            if(length == l) {symbol.Add(Convert.ToInt32(matrix[i, j])); symbolAmount.Add(1); l++;}
        }
    }
    symbolAmount[0] = symbolAmount[0] - 1;
    double allAmount = (((matrix.GetLength(0) + 1)) * (matrix.GetLength(1) + 1));
    double percent = 0;
    for (int k = 0; k < l; k++)
    {
        percent = (symbolAmount[k] / allAmount) * 100;
        percent = Math.Round(percent, 2);
        Console.WriteLine($"Символ {symbol[k]} встречается {symbolAmount[k]} раз. Частота {percent}%.");
    }
}

int[,] matrix = Matrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
freqDictionary(matrix);