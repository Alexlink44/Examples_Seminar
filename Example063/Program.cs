// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента.

string[,,] array = new string[3,3,3];
int A = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            if(A < 10) {array[i, j, k] = "0" + Convert.ToString(A); A++;}
            else {array[i, j, k] = Convert.ToString(A); A++;}
            Console.WriteLine($"{array[i, j, k]} ({i + 1},{j + 1},{k + 1})");
        }
    }
}