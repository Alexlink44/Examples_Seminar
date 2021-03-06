// Показать кубы чисел, заканчивающихся на четную цифру.

int[] Numbers(int amount)
{
    int[] numbers = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        numbers[i] = new Random().Next(1, 50);
        Console.Write($"{numbers[i]}   ");
    }
    return numbers;
}

void EvenCubes(int[] numbers)
{
    int number = 0;
    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        if (numbers[i] % 2 == 0 && numbers[i] % 10 != 0)
        {
            number = numbers[i] * numbers[i] * numbers[i];
            Console.WriteLine($"{numbers[i]}^3 = {number}");
        }
    }
}

int[] numbers = Numbers(10);
Console.WriteLine();
Console.WriteLine();
EvenCubes(numbers);