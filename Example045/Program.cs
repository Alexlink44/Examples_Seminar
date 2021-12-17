// Показать числа Фибоначчи

double number1 = 0;
double number2 = 0;
double number3 = 1;
double length = 50;
for (int i = 0; i < length; i++)
{
    number1 = number2;
    number2 = number3;
    Console.WriteLine($"!{i} = {number3}");
    number3 = number3 + number1;
}