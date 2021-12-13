//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void SumPairsNumbers(int[] array)
{
    //int lengt = array.Length;
    int j = array.Length - 1;
    for (int i = 0; i < j; i++)
    {
        Console.WriteLine($"{i + 1}-я пара = {array[i] * array[j]}");
        j = j - 1;
    }
}

int size = new Random().Next(2, 11);
int[] array = Array(size);
SumPairsNumbers(array);