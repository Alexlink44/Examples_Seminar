// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 ==0) Console.WriteLine($"Число {num} кратно 7 и 23");
    else
    {
        Console.WriteLine($"Число {num} не кратно 7 и 23");
    }
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23");
}