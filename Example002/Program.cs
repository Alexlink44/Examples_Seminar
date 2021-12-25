// Даны два числа. Показать большее и меньшее число.

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int temp = number1;
if (number1 < number2) {number1 = number2; number2 = temp;}
Console.Write($"{number1} - большее число, {number2} - меньшее число.");