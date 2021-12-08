// Возведите число А в натуральную степень B используя цикл.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Определите степень возведения числа: ");
int degree = int.Parse(Console.ReadLine());
int total = number;
for (int i = 1; i < degree; i++)
{
    total = number * total;
}
Console.Write(total);