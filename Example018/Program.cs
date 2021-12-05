// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
int EX(int Z, int X)
{
    if (Z % 2 == 0) X = 0;
    else X = 1;    
    return X;
}

void F(int X, int Y)
{
    Console.Write($"{X}, {Y} ");   
    int F1 = 0;
    if (X + Y > 0) F1 = 0;
    else F1 = 1;

    int F2 = 0;
    int X2 = 0;
    int Y2 = 0;
    if (X > 0) X2 = 0;
    else X2 = 1;
    if (Y > 0) Y2 = 0;
    else Y2 = 1;
    if (X2 * Y2 > 0) F2 = 1;
    else F2 = 0;

    if (F1 == F2) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
int X = 0;
int Z = 0;
int Y = 0;
while (Z < 2)
{
    X = EX(Z, X);
    F(X, Y);
    if (X == 0) Y = 1;
    else Y = 0;
    F(X, Y);
    Z++;
}