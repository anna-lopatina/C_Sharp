// Программа которая принимает на вход число N и выдает таблицу квадратов
// чисел от 1 до N

void Kvadrat(int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i}");
        if(i != n)
        {
           Console.Write(", "); 
        }
    }
}

Console.Clear();
Console.Write("введите число N ");
int N = int.Parse(Console.ReadLine()!);
Kvadrat(N);
