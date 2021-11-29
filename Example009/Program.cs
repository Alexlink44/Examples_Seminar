//Показать последнюю цифру трёхзначного числа
//int NewNumber = new Random().Next(100, 1000);
//string Number = NewNumber.ToString();
//Console.Write($"{Number[2]}");

int NewNumber = new Random().Next(100, 1000);
Console.WriteLine("Number - {0}", NewNumber);
int Res = NewNumber % 10;
Console.WriteLine("Последняя цифра числа - {0}", Res);