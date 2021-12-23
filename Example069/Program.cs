// Рекурсия.
// Найти сумму элементов от M до N, N и M заданы.

void SumMN(int M, int N, int sum)
{
    if (M <= N) {SumMN(M + 1, N, sum + M);}
    else {Console.WriteLine(sum);}
}

SumMN(1, 5, 0);