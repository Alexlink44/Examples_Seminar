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
    int A = 0;
    for (int p = 0; p < count; p++)
    {
        if (numbers[p] % 2 == 0)
        {
            A++;
        }
    }
    int[] T = new int [A];
    int B = 0;
    int P = 0;
    while (P < count)
    {
        if (numbers[P] % 2 == 0)
        {
            T[B] = numbers[P];
            Console.Write(T[B]);
            B++;
            if (A == B) Console.Write(".");
            else Console.Write(", ");
        }
        P++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
PrintArrayResult(array);