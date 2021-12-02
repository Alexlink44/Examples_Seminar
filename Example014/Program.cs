// Найти третью цифру числа или сообщить, что её нет

Console.Write("Enter number: ");
// string num = Console.ReadLine();
// int length = num.Length;
// if (length < 3)
// {
//     Console.WriteLine("Третьей цифры не существует");
// }
// else
// {
// Console.WriteLine(num[2]);
// }
int num = int.Parse(Console.ReadLine());
if (-100 < num && num < 100)
    Console.WriteLine("Третьей цифры не существует");
else
{
    while (num / 1000 > 0)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}