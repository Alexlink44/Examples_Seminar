//Показать вторую цифру трёхзначного числа

int NewNumber = new Random().Next(100, 1000);
Console.WriteLine("Number - {0}", NewNumber);
int Temp = NewNumber / 10;
int Res = Temp % 10;
Console.WriteLine("Вторая цифра трёхзначного числа - {0}", Res);