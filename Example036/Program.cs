// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i == 0) {Console.Write($"[{array[i]}, ");}
        if (i == (size - 1)) {Console.Write($"{array[i]}]");}
        if (i > 0 && i < (size - 1)) {Console.Write($"{array[i]}, ");}
    }
    return array;
}

void ParityCheck(int[] array)
{
    Console.WriteLine();
    int evenNumbers = 0;
    int oddNumbers = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) {evenNumbers = evenNumbers + 1;}
        else {oddNumbers = oddNumbers + 1;}
    }
    Console.WriteLine($"Количество чётных чисел - {evenNumbers}");
    Console.Write($"Количество нечётных чисел - {oddNumbers}");
}


int size = 5;
int[] array = Array(size);
ParityCheck(array);