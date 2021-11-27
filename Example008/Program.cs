//Показать четные числа от 1 до N
void FillArray(int[] naturalNumbrs)
{
    int lengthN = naturalNumbrs.Length;
    for (int i = 0; i < lengthN; i++)
    {
        naturalNumbrs[i] = new Random().Next(1, 1001);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
        if (position < count) Console.Write(", ");
        else Console.WriteLine(".");
    }
}

void PrintArrayResult(int[] numbers)
{
    int count = numbers.Length;
    Console.WriteLine();
    for (int p = 0; p < count; p++)
    {
        if (numbers[p] % 2 == 0)
        {
            Console.Write($"{numbers[p]}");
        }
        if (p == count - 1)
        {
            Console.Write(".");
            break;
        }
        if (numbers[p] % 2 == 0)
        {
            Console.Write(", ");
        }
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
PrintArrayResult(array);