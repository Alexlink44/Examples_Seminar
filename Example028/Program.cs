// Подсчитать сумму цифр в числе

Console.Write("Enter number: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num < 0) num = num * (-1);
string number = Convert.ToString(num);
Console.WriteLine(number);

int[] Array(string number)
{
    int length = number.Length;
    int[] numb = new int[length];
    char value = ',';
    for (int i = 0; i < length; i++)
    {
        if(number[i] == value) numb[i] = 0;
        else numb[i] = (int)(number[i] - '0');
        //(int)Char.GetNumericValue(number[i]);
        //Convert.ToInt32(number[i]) -48; ---
    }
    return numb;
}

int[] numb = Array(number);
int resalt = 0;
int len = numb.Length;
for (int i = 0; i < len; i++)
{
    resalt = numb[i] + resalt;
}

Console.WriteLine(resalt);
// string number = "1";
// int numb = Convert.ToInt32(number[0]);
// Console.WriteLine(numb);