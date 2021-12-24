// Рекурсия.
// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем.

Console.WriteLine("Введите первое число ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
void SumNumtoN(double number1, double number2, int N)
{
    if (N > 0)
    {
        Console.WriteLine(number1 + number2); SumNumtoN(number2, number1 + number2, N - 1);
    }
}

SumNumtoN(number1, number2, 5);