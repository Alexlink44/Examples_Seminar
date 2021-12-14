// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] Array(int size)
{
    double[] array = new double[size];
    double k = 0;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        k = new Random().Next(1, 10);
        array[i] = new Random().Next(-200, 200);
        array[i] = Math.Round(array[i] / k, 3);
        if (i == (size - 1)) {Console.WriteLine($"{array[i]}]");}
        if (i < (size - 1)) {Console.Write($"{array[i]}; ");}
    }
    return array;
}

void FindDifference(double[] array)
{
    double difference = 0;
    int length = array.Length;
    int max = 0;
    int min = 0;
    for (int i = 1; i < length; i++)
    {
        if (array[i] > array[max]) {max = i;}
        if (array[i] < array[min]) {min = i;}
    }
    Console.WriteLine($"max = {array[max]}, min = {array[min]}");
    difference = array[max] - array[min];
    Console.WriteLine($"Разница {difference}");
}


double[] array = Array(15);
FindDifference(array);