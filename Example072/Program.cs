// Рекурсия.
//Написать программу возведения числа А в целую стень B.

double Exponentiation(double A, int B)
{
    if (B > 0) return Exponentiation(A, B - 1) * A;
    else
    {
        return 1;
    }
}

Console.Write(Exponentiation(3, 3));