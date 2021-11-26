//Показать числа от -N до N
int[] nN = new int[2];

void FillArray(int[] naturalNumbrs)
{
    int lengthN = 2;
    int index = 0;
    while (index < lengthN)
    {
        naturalNumbrs[index] = new Random().Next(-5, 10);
        index++;
    }
}

void PrintArray(int[] Nnumbers)
{
    int count = Nnumbers.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(Nnumbers[position]);
        if (position == 1)
        {
            Console.WriteLine(".");
            break;
        }
        Console.Write(", ");
        position++;
    }
}


void ArraynN(int[] collection)
{
    int n = collection[0];
    int N = collection[1];
    int index = 1;
    while (n < N)
    {
        n = n + 1;
        index = index + 1;
    }
    int[] NN = new int[index];
    int I = 0;
    n = collection[0];
    while (n <= N)
    {
        NN[I] = n;
        Console.Write(NN[I]);
        if(NN[I] == N) Console.Write(".");
        else
        {
            Console.Write(", ");
        }
        n = n + 1;
        I = I + 1;
    }
}

FillArray(nN);
PrintArray(nN);
ArraynN(nN);