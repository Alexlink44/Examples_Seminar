//Выяснить является ли число чётным
double number = new Random().Next(1, 1001);
Console.WriteLine(number);
double rem = number % 2;
if (rem == 0)
{
Console.WriteLine(number);
Console.WriteLine(" - число является чётным");
}
else
{
Console.WriteLine(number);
Console.WriteLine(" - число НЕ является чётным");
}