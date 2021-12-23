// Рекурсия.
// Показать натуральные числа от 1 до N, N задано.

void NNumbers(int N)
{
    if (N > 0) {NNumbers(N - 1); Console.WriteLine(N);}
}

NNumbers(10);