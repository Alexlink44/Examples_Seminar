// Рекурсия.
// Показать натуральные числа от M до N, N и M заданы.

void MNNumbers(int M, int N)
{
    if (M < N) {Console.WriteLine(M); MNNumbers(M + 1, N);}
    else if (N < M) {Console.WriteLine(N); MNNumbers(N + 1, M);}
    else {Console.WriteLine(N);}
}

MNNumbers(20, 5);