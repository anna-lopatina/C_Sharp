// Программу которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве

Console.Clear();
Console.Write("Введите координаты Х точки А: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Y точки А: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите кординаты Х точки В: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Y точки В: ");
int by = int.Parse(Console.ReadLine()!);

double Dist(int x1, int y1, int x2, int y2)
{
    double l = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
    double z = Math.Sqrt(l);
    return z;
}

Console.WriteLine($"Расстояние между точками {Dist(ax, ay, bx, by):f2}");
