// Найти расстояние между точками в пространстве 2D/3D
int[] Points(int dimension)
{
    int[] point = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        point[i] = new Random().Next(-50, 50);
        if (i == 0) { Console.Write(" = ("); }
        Console.Write($"{point[i]}");
        if (i < dimension - 1) { Console.Write(", "); }
        if (i == dimension - 1) { Console.Write(")."); }
    }
    return point;
}

void DistanceBetweenPoints(int[] firstPoint, int[] secondPoint, int dimension)
{
    int distance = 0;
    for (int i = 0; i < dimension; i++)
    {
        distance = ((firstPoint[i] + secondPoint[i]) * (firstPoint[i] + secondPoint[i])) + distance;
    }
    distance = Convert.ToInt32(Math.Sqrt(distance));
    Console.WriteLine("");
    Console.WriteLine(distance);
}




int dimension = 2;
int[] firstPoint = new int[dimension];
int[] secondPoint = new int[dimension];
Console.Write("X");
firstPoint = Points(dimension);
Console.WriteLine();
Console.Write("Y");
secondPoint = Points(dimension);
DistanceBetweenPoints(firstPoint, secondPoint, dimension);