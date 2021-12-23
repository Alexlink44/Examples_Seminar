// Рекурсия.
// Найти сумму элементов от M до N, N и M заданы.

void SumMN(int M, int N, int sum)
{
    if (M < N) {SumMN(M + 1, N, sum + M);}
    else if (N < M) {SumMN(N + 1, M, sum + N);}
    else {Console.WriteLine(sum + N);}
}

SumMN(5, 1, 0);