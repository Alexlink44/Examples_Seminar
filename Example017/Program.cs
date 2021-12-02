// По двум заданным числам проверить является ли одно квадратом другого

Console.Write("Enter number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
if ((num1 / num2) == num2 || (num2 / num1) == num1)
{
    if ((num1 / num2) == num2) Console.WriteLine("Первое число является квадратом второго");
    if ((num2 / num1) == num1) Console.WriteLine("Второе число является квадратом первого");
}
else
{
   Console.WriteLine("Ни одно из чисел не является квадратом другого");
}