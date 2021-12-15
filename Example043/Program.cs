// Написать программу преобразования десятичного числа в двоичное.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int numberDivision = 3;
string result = "";
string numberResult = "";
if (number < 0) {numberResult = "1 "; number = number * (-1);}
else {numberResult = "0 ";}
while (numberDivision > 1)
{
    numberDivision = number / 2;
    result = result + Convert.ToString(number - numberDivision * 2);
    number = numberDivision;
    Console.WriteLine(number);
}
result = result + Convert.ToString(number);
Console.WriteLine();
Console.WriteLine(result);

//переполнение типа
// int numberResult = 0;
// int length = result.Length;
// int i = length - 1;
// while (i >= 0)
// {
//     numberResult = numberResult * 10;
//     Console.Write($"{numberResult}  ");
//     numberResult = numberResult + (result[i] - 48);
//     Console.Write($"{numberResult}  ,");
//     i = i - 1;
// }

int length = result.Length - 1;
while (length >= 0)
{
    numberResult = numberResult + result[length];
    length = length - 1;
}

Console.Write(numberResult);