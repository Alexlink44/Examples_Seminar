// Написать программу вычисления произведения чисел от 1 до N.

Console.Write("Введите конечное число N: ");
int number = int.Parse(Console.ReadLine());
int result = 1;
int temp = 1;
while (temp < number)
{
    temp = temp + 1;
    result = result * temp;
}

Console.WriteLine(result);