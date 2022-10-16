// Программа, на вход принимает координаты точки (X, Y), причем 
// X, Y не равны нулю и выдает номер четверти, в которой находится точка

Console.Clear();
Console.Write("Введите Х: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);

if(x > 0)
{
    if(y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Четвертая четверть");
    }
}
else
{
    if(y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}