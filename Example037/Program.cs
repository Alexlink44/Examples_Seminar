// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 500);
        if (i == 0) {Console.Write($"[{array[i]}, ");}
        if (i == (size - 1)) {Console.WriteLine($"{array[i]}]");}
        if (i > 0 && i < (size - 1)) {Console.Write($"{array[i]}, ");}
    }
    return array;
}

void FindElements(int[] array)
{
    int amount = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 9 && array[i] < 100) {amount = amount + 1;}
    }
    Console.Write($"Количество элементов из отрезка [10,99] равно {amount}");
}

int size = 123;
int[] array = Array(size);
FindElements(array);