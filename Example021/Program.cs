// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите число");
string Number = Console.ReadLine();
int length = Number.Length;
int numB = Convert.ToInt32(Number);
int[] Num = new int[length];
int i = length -1;
while (i + 1> 0)
{
    Num[i] = numB % 10;
    numB = numB / 10;
    i = i - 1;
}
i = 0;
int j = length - 1;
while (Num[i] == Num[j] && i < j)
{
    j = j - 1;
    i++;
}
if (i == length/2) Console.WriteLine("Число является палиндромом");
else
{
    Console.WriteLine("Число не является палиндромом");
}