// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int GetAkk(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return GetAkk(m - 1, 1);
    }
    else
    return GetAkk(m - 1, GetAkk(m, n - 1));
}

Console.Clear();
Console.Write("Введите неотрицательное число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetAkk(m, n));