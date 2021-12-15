// Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```

Console.Write("Задайте вершины фигуры (X,Y): ");
string data = Convert.ToString(Console.ReadLine());
Console.Write("Введите коэффициент: ");
int factor = int.Parse(Console.ReadLine());
int length = data.Length;
char char1 = '(';
char char2 = ')';
char char3 = ',';
char char4 = '.';
char char5 = ';';
char char6 = ' ';
string temp ="";
int k = 0;
int h = 0;
var vertices = new List<int>();
for (int i = 0; i < length; i++)
{
    if (data[i] != char1 && data[i] != char2 && data[i] != char3
    && data[i] != char4 && data[i] != char5 && data[i] != char6)
    {temp = temp + data[i]; k++;}
    else
    {
        if (k > 0) {vertices.Add(Convert.ToInt32(temp)); temp = ""; h++; k = 0;}
    }
}
//Console.Write(vertices[0]);

int j = 0;
for (int i = 0; i < h; i++)
{
    vertices[i] = vertices[i] * factor;
    if (j == 1)
    {
        Console.Write($"{vertices[i]}) ");
        j = 0;
    }
    else
    {
        Console.Write($"({vertices[i]}, ");
        j = 1;
    }
}