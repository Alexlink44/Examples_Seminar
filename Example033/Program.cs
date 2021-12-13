// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.

int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
    int k = new Random().Next(0, 2);
    array[i] = new Random().Next(0, 11);
    if (k == 1) array[i] = array[i] * (-1);
   Console.Write($"{array[i]}  ");
}
int positive = 0;
int negative = 0;
for (int j = 0; j < 12; j++)
{

    if (array[j] > 0) {positive = positive + array[j];}
    if (array[j] < 0) {negative = negative + array[j];}
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов равна {positive}");
Console.WriteLine($"Сумма отрицательных элементов равна {negative}");