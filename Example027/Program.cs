// Определить количество цифр в числе.

Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
if (number < 0) {number = number * (-1);}
while (number % 1 > 0) {number = number * 10;}
Console.WriteLine(number);
int i = 0;
int num = Convert.ToInt32(number);
while (num > 0)
{
    num = num / 10;
    i++;
}
Console.Write($"Количество цифр в числе равно {i}");