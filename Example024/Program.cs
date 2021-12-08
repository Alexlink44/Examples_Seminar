// Найти кубы чисел от 1 до N

Console.Write("Задайте N: ");
int number = int.Parse(Console.ReadLine());
int k = 0;
for (int i = 1; i <= number; i++)
{
    int indentSize = 9;
    string numberlength = Convert.ToString(i);
    int j = i * i * i;
    string lengthOfNumber = Convert.ToString(j);
    int length = numberlength.Length + lengthOfNumber.Length;
    indentSize = indentSize - length;
    for (int h = 1; h < indentSize; h++) { Console.Write(" "); }
    Console.Write($"{i}^3 = {j}");
    k++;
    if (k == 5) { Console.WriteLine(); k = 0; }
}