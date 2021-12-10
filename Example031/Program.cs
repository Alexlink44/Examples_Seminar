//Задать массив из 8 элементов и вывести их на экран

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(-100, 100);
}
for (int i = 0; i < 8; i++)
{   if (i == 0 || i == 7)
    {
        if (i == 0) {Console.Write("{"); Console.Write($"{array[i]}, ");}
        if (i == 7) {Console.Write($"{array[i]}"); Console.Write("}");}
    }
    else {Console.Write($"{array[i]}, ");}
}