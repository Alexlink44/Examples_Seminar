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
            Console.Write($"{matrix[i, j]} ");
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
    while(A <= matrix.Length)
    {
        for (;i >= 0 && i < trolley; i = i + i2)
        {
            for (;j >= 0 && j < line; j = j + j2)
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
    }
    

    return matrix;
}

int[,] matrix = new int[5,5];


Spiral(matrix);

PrintMatrix(matrix);