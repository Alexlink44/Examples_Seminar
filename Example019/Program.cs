// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int[] XYdef()
{
    int[] XY = new int[2];
    for (int i = 0; i < 2; i++)
    {
        XY[i] = new Random().Next(-10, 10);
    }
    if (XY[0] == 0 || XY[1] == 0)
    {
        return XYdef();
    }
    else return XY;
}

void defQuarter(int[] XY)
{
    if (XY[0] > 0 && XY[1] > 0) Console.WriteLine("First Quarter");
    if (XY[0] < 0 && XY[1] > 0) Console.WriteLine("Second Quarter");
    if (XY[0] < 0 && XY[1] < 0) Console.WriteLine("Third Quarter");
    if (XY[0] > 0 && XY[1] < 0) Console.WriteLine("Fourth Quarter");
}
int[] XY = new int[2];
XY = XYdef();
Console.WriteLine($"{XY[0]}, {XY[1]}");
defQuarter(XY);


