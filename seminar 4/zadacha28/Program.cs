// Программа, которая принимает на вход число N и выдает произведение 
// чисел от 1 до N
// 4 -> 24
// 5 -> 120

int GetUmn(int n)
{
    int umn = 1;
    for (int i = 1; i <= n; i++)
    {
        umn = umn * i; 
    }
    return umn;
}

Console.Clear();
Console.WriteLine("Введите N ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetUmn(N));
