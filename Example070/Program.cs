// Рекурсия.
//Найти сумму цифр числа.

int SumNumber(int number)
{
    if (number > 0) {return SumNumber(number / 10) + (number % 10);}
    else return 0;
}

Console.WriteLine(SumNumber(123));