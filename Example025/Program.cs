// Найти сумму чисел от 1 до А.

Console.Write("Enter number A: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите шаг: ");
double step = Convert.ToDouble(Console.ReadLine());

// double len = ((number - 1) / step) + 1;
// Console.WriteLine(len);
// len = Math.Truncate(len);
// int length = Convert.ToInt32(len);
// Console.WriteLine(length);
// if ((number - 1) % step == 0) {length = length - 1;}
// Console.WriteLine(length);


// double set = 1;
// double k = 1;

// for (int i = 1; i <= length; i++)
// {
//     if (i == length) {set = set + number;}
//     else 
//     {
//         k = k + step;
//         Console.WriteLine(k);
//         set = set + k;
//     }
// }

// Console.WriteLine(set);

/////////////////////////////////////////////////////////////////

double set = 0;
double k = 1;
while (k < number)
{
    Console.WriteLine(k);
    set = set + k;
    k = k + step;
    
}
Console.WriteLine(number);
set = set + number;

Console.WriteLine(set);