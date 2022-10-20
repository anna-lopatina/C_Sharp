// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1, y = k2*x+b2, значения b1, b2, k1, k2 
// задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Peresechenie (double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельные");
        }
    }
    else{
        double x = (b1 - b2)/(k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых равна ({x};{y})");
    } 
}

Console.Clear();
Console.WriteLine("Введите коэффициент k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine()!);
Peresechenie(k1, k2, b1, b2);


  
