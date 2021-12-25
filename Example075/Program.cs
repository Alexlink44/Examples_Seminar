// Есть два массива info и data. 
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей. 
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 
// Пример:
// ```
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1
// ```
// Какие ошибки могут возникнуть при обработке наборов данных?

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

int[] BinaryToDecimal(int[] data, int[] info)
{
    int[] decima = new int[info.Length];
    int t = 0;
    int j = 0;
    for (int i = 0; i < info.Length; i++)
    {
        t = t + info[i];
        for (; j < t; j++)
        {
            decima[i] = decima[i] * 2 + data[j];
        }
    }
    return decima;
}

int[] decima = BinaryToDecimal(data, info);

for (int i = 0; i < decima.Length; i++)
{
    Console.WriteLine(decima[i]);
}