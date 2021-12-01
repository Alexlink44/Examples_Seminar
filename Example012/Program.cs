//Удалить вторую цифру трёхзначного числа
int NewNumber = new Random().Next(100, 1000);
Console.WriteLine("Number - {0}", NewNumber);
int Temp1 = NewNumber / 100;
int Temp2 = NewNumber % 10;
Temp1 = Temp1 * 10;
int Result = Temp1 + Temp2;
Console.WriteLine(Result);