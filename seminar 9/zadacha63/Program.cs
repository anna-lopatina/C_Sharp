// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

string GetPrint(int start, int end)
{
    if (start == end) 
    {
        return start.ToString();
    }
    Console.WriteLine($"f({start},{end}) -> {start + " " + GetPrint(start + 1, end)}");
    return start + " " + GetPrint(start + 1, end);
}

Console.Clear();
Console.Write("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(GetPrint(m, n));