// Найти третью цифру числа или сообщить, что её нет

Console.Write("Enter number: ");
string num = Console.ReadLine();
int length = num.Length;
if (length < 3)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
Console.WriteLine(num[2]);
}