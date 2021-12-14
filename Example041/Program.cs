//Выяснить являются ли три числа сторонами треугольника

int Sides()
{
    int number = new Random().Next(1, 20);
    Console.Write($"{number}  ");
    return number;
}

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) {Console.Write("Числа являются сторонами треугольника.");}
    else {Console.Write("Числа не являются сторонами треугольника");}
}



int A = Sides();
int B = Sides();
int C = Sides();
Console.WriteLine();
Triangle(A, B, C);
