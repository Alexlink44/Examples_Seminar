// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

Console.Write("Задайте k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Задайте k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.Write("Задайте b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Задайте b2: ");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine($"b1 = {b1}, b2 = {b2}, k1 = {k1}, k2 = {k2}.");

// if (b1 != b2 && k1 == k2) {Console.WriteLine("Прямые параллельны и не пересекаются.");}
// if (b1 == b2 && k1 == k2) {Console.WriteLine("Прямые совпадают.");}
// if (k1 != k2)

if (k1 == k2)
{
    if (b1 != b2) {Console.WriteLine("Прямые параллельны и не пересекаются.");}
    if (b1 == b2) {Console.WriteLine("Прямые совпадают.");}
}
else
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.Write($"Прямые пересекаются в точке ({x}, {y}).");
}