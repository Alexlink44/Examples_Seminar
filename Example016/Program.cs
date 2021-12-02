// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num == 6) Console.WriteLine("Этот день недели - выходной");
else
{
    if (num == 7) Console.WriteLine("Этот день недели - выходной");
    else Console.WriteLine("Этот день недели - НЕ является выходным");
}