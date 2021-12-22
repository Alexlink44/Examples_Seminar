// Рекурсия.
// Показать натуральные числа от N до 1, N задано.

void NNumbers(int N)
{
    if (N > 0) {Console.WriteLine(N); NNumbers(N - 1);}
}

NNumbers(5);