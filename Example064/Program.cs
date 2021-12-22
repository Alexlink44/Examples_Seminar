// Показать треугольник Паскаля.
// *Сделать вывод в виде равнобедренного треугольника.

void PrintMatrix(string[,] matrix)
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

void PrintMatrix1(int[,] matrix)
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

int m = 11;
int[,] pascal = new int[m, (2 * m - 1)];
int position = pascal.GetLength(1) / 2;
pascal[0, position] = 1;
for (int i = 1; i < pascal.GetLength(0); i++)
{
    for (int j = 0; j < pascal.GetLength(1); j++)
    {
        if (j == 0 || j == (pascal.GetLength(1) - 1))
        {
            if (j == 0) {pascal[i, j] = pascal[(i - 1), (j + 1)];}
            else {pascal[i, j] = pascal[(i - 1), (j - 1)];}
        }
        else {pascal[i, j] = pascal[(i - 1), (j - 1)] + pascal[(i - 1), (j + 1)];}
    }
}


int num = 0;
string temp = "";
char char1 = ' ';
int max = pascal[(pascal.GetLength(0) - 1), 0];
string[,] pascalTriangle = new string[pascal.GetLength(0), pascal.GetLength(1)];

for (int u = 1; u < pascal.GetLength(1); u++)
{
    if (pascal[(pascal.GetLength(0) - 1), u] > max) {max = pascal[(pascal.GetLength(0) - 1), u];}
}
temp = Convert.ToString(max);
max = temp.Length;

for (int i = 0; i < pascal.GetLength(0); i++)
{
    for (int j = 0; j < pascal.GetLength(1); j++)
    {
        if (pascal[i, j] == 0)
        {
            num = max;
            for (int k = 0; k < num; k++)
            {
                pascalTriangle[i, j] = pascalTriangle[i, j] + char1;
            }
        }
        else
        {
            temp = Convert.ToString(pascal[i, j]);
            num = max - temp.Length;
            for (int k = 0; k < num; k++)
            {
                pascalTriangle[i, j] = pascalTriangle[i, j] + char1;
            }
            pascalTriangle[i, j] = pascalTriangle[i, j] + Convert.ToString(pascal[i, j]);
        }
    }
}





Console.WriteLine();
PrintMatrix(pascalTriangle);