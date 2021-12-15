// Показать числа Фибоначчи

int number1 = 0;
int number2 = 0;
int number3 = 1;
int length = 10;
for (int i = 0; i < length; i++)
{
    number1 = number2;
    number2 = number3;
    Console.Write($"{number3}, ");
    number3 = number3 + number1;
}
Console.Write($"{number3}.");