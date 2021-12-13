// Определить, присутствует ли в заданном массиве, некоторое число.

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

void FindNumber(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Введите искомое число: ");
    int number = int.Parse(Console.ReadLine());
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        if (array[i] == number) {Console.WriteLine($"Искомое число является {i + 1}-м элементом массива"); break;}
        i++;
    }
    if (i == length && array[i - 1] != number) {Console.WriteLine("Искомое число не найдено в данном массиве");}
}

int size = 5;
int[] array = Array(size);
FindNumber(array);