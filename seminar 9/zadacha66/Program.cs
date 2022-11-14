// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int start, int end)
{
    if (start == end) 
    {
        return start;
    }
    return start + GetSum(start + 1, end);
}

Console.Clear();
Console.Write("Введите начальное число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(m, n));