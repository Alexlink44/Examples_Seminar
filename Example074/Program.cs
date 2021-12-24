// Рекурсия.
//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

char[] alfabet = { 'а', 'и', 'с', 'в' };

// Общий вид.
// int wrdLnth = 4;
// int count = alfabet.Length;
// int[] wordsNum = new int[wrdLnth];
// int m = 0;
// int num = 1;
// while (wordsNum[0] < count)
// {
//     m = wrdLnth - 2;
//     for (int i = 0; i < count; i++)
//     {
//         wordsNum[wrdLnth - 1] = i;
//         Console.Write($"{num}: ");
//         num++;
//         for (int j = 0; j < wrdLnth; j++)
//         {
//             Console.Write(alfabet[wordsNum[j]]);
//         }
//         Console.WriteLine();
//     }
//     wordsNum[m] = wordsNum[m] + 1;
//     if (wordsNum[m] == count)
//     {
//         while (wordsNum[m] == count)
//         {
//             if (m > 0)
//             {
//                 wordsNum[m] = 0;
//                 m--;
//                 wordsNum[m] = wordsNum[m] + 1;
//             }
//             else {wordsNum[m] = wordsNum[m] + 1;}
//         }
//     }
// }

// Через рекурсию.

int n = 1;
void Words(char[] alfabet, int lnthwrd, string word = "", int length = 0)
{
    if (length == lnthwrd)
    {
        Console.WriteLine($"{n++}: {word}"); return;
    }
    else
    {
        for (int i = 0; i < alfabet.Length; i++)
        {
           Words(alfabet, lnthwrd, word + alfabet[i], length + 1);
        }
    }
}

Words(alfabet, 2);