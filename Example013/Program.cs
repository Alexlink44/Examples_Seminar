// Выяснить, кратно ли число заданному, если нет, вывести остаток.
void Method(int given)
{
    Console.Write("Введите число ");
    int numb = int.Parse(Console.ReadLine());
    if (given % numb == 0) Console.WriteLine($"Число {numb} кратно заданному");
    else Console.WriteLine(given % numb);
}

Method(3);