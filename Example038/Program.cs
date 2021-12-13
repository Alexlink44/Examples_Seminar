// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[] Array(int size)
{
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-50, 50);
        if (i == (size - 1)) {Console.WriteLine($"{array[i]}]");}
        if (i < (size - 1)) {Console.Write($"{array[i]}, ");}
    }
    return array;
}

void SumOddArray(int[] array)
{
    int length = array.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if ((i + 1) % 2 != 0) {sum = sum + array[i];}
    }
    Console.Write(sum);
}

int size = 5;
int[] array = Array(size);
SumOddArray(array);