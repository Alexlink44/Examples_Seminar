//Определить сколько чисел больше 0 введено с клавиатуры

int[] numbers = new int[10];
for (int j = 0; j < 10; j++)
{
    Console.Write($"Введите число {j + 1}: ");
    numbers[j] = Convert.ToInt32(Console.ReadLine());
}
int length = numbers.Length;
int amount = 0;
for (int i = 0; i < length; i++)
{
    if (numbers[i] > 0) {amount = amount + 1;}
}
Console.WriteLine();
Console.Write($"{amount} чисел больше 0 введено с клавиатуры");