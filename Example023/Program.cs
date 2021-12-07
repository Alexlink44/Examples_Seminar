// Показать таблицу квадратов чисел от 1 до N.
Console.Write("Задайте N: ");
int table = int.Parse(Console.ReadLine());
int column = table / 10;
for (int k = 0; k <= 9; k++) {Console.Write($"       {k}");}
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i <= column; i++)
{
    Console.Write($"{i}");
    for (int j = 0; j <= 9; j++)
    {
        int indentSize = 9;
        int number = ((i * 10) + j) * ((i * 10) + j);
        string numberlength = Convert.ToString(number);
        int length = numberlength.Length;
        indentSize = indentSize - length;
        for (int h = 1; h < indentSize; h++){Console.Write(" ");}
        Console.Write(number);
        }
    Console.WriteLine();
    Console.WriteLine();
}