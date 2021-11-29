//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number = new Random().Next(10, 100);
Console.WriteLine(Number);
int A = Number % 10;
int B = Number / 10;
if (A == B) Console.Write($"Число {Number} симметричное");
else
{
    if (B > A)
    {
        Console.WriteLine($"Цифра второго порядки числа {Number} наибольшая");
    }
    else
    {
     Console.WriteLine($"Цифра первого порядки числа {Number} наибольшая");
    }
}