// Рекурсия.
//Найти сумму цифр числа.

int SumNumber(int number, int result)
{
    if (number > 0) {result = SumNumber(number / 10, result) + (number % 10); return result;}
    else return 0;
}

Console.WriteLine(SumNumber(123, 0));