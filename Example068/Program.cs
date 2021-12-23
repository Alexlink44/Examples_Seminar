// Рекурсия.
// Показать натуральные числа от M до N, N и M заданы.

void MNNumbers(int M, int N)
{
    if (M <= N) {Console.WriteLine(M); MNNumbers(M + 1, N);}
}

MNNumbers(5, 20);