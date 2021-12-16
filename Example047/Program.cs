// Написать программу копирования массива.

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 11);
        if (i == 0) {Console.Write($"[{array[i]}, ");}
        if (i == (size - 1)) {Console.Write($"{array[i]}]");}
        if (i > 0 && i < (size - 1)) {Console.Write($"{array[i]}, ");}
    }
    return array;
}

int[] ArrayCopy(int[] arrOriginal, int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = arrOriginal[i];
    }
    return arr;
}



int size = 5;
int[] array = Array(size);
Console.WriteLine();
int[] arr = ArrayCopy(array, array.Length);
for (int i = 0; i < size; i++)
{
    if (i == 0) {Console.Write($"[{arr[i]}, ");}
    if (i == (size - 1)) {Console.Write($"{arr[i]}]");}
    if (i > 0 && i < (size - 1)) {Console.Write($"{arr[i]}, ");}
}