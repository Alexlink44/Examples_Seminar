int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int max = numberA;
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 10);
Console.WriteLine(numberC);

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);