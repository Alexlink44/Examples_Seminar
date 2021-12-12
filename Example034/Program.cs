// Написать программу замену элементов массива на противоположные.

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
        if (i == 0) {Console.Write($"[{array[i]}, ");}
        if (i == (size - 1)) {Console.Write($"{array[i]}]");}
        if (i > 0 && i < (size - 1)) {Console.Write($"{array[i]}, ");}
    }
    return array;
}

void ArrayReverse(int[] array)
{
    int i = 0;
    int length = array.Length;
    int j = length - 1;
    int temp = 0;
    while (i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j = j - 1;
    }
    Console.WriteLine();
    for (int k = 0; k < length; k++)
    {
        if (k == 0) {Console.Write($"[{array[k]}, ");}
        if (k == (length - 1)) {Console.Write($"{array[k]}]");}
        if (k > 0 && k < (length - 1)) {Console.Write($"{array[k]}, ");}
    }
}


int size = new Random().Next(5, 10);
int[] array = Array(size);
ArrayReverse(array);