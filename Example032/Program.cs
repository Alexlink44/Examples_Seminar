// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

string[] array = new string[8];
for (int i = 0; i < 8; i++)
{
    int k = new Random().Next(1, 6);
    string temparray = String.Empty;
    for (int j = 0; j < k; j++)
    {
        int h = new Random().Next(1, 3);
        if(h == 1) temparray = temparray + '1';
        else temparray = temparray + '0';
    }
    // Console.WriteLine(temparray);

    array[i] = temparray;
    // Console.WriteLine(array[i]);
}




Console.Write("{");
for (int i = 0; i < 8; i++)
{   if (i == 7)
    {
        Console.Write($"{array[i]}"); Console.Write("}");
    }
    else {Console.Write($"{array[i]}, ");}
}