//Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
// ```



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Spiral(int [,] matrix)
{
    int A = 1;
    int line = matrix.GetLength(0);
    int trolley = matrix.GetLength(1);
    int i = 0;
    int j = 0;
    int j2 = 1;
    int i2 = 1;
    int k = 0;
    int h = 0;
    while(A <= matrix.Length)
    {
        for (;i >= 0 + k + h && i < trolley - h; i = i + i2) //строка
        {
            for (;j >= 0 + h && j < line - h; j = j + j2) //столбец
            {
                matrix[i, j] = A;
                A++;
            }
            j = j - j2;
        }
        i = i - i2;
        i2 = i2 * (-1);
        j2 = j2 * (-1);
        j = j + j2;
        k++;
        if (k == 2) {k = 0; h++;}
    }
    return matrix;
}


int[,] matrix = new int[10,10];


Spiral(matrix);

PrintMatrix(matrix);