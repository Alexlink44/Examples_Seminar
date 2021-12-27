// Задача 1
// ---
// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые
// - делятся на k, но не на l
// - делятся хотябы на k или на l
// - не делятся на (k + l)

Console.Write("Задайте число-ограничение n: ");
int numLimit = int.Parse(Console.ReadLine());
int k = 3;
int l = 7;

int DivisibleByKButNotL(int numLimit, int k, int l)
{
    int result = 1;
    for (int i = 1; i < numLimit; i++)
    {
        if (i % k == 0 && i % != 0) {}
    }
    return
}