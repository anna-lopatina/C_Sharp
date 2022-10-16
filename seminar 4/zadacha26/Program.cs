// Программа, которая принимает на вход число и 
// выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Cifra(int A)
{
    int n = 1;
    int b = 1;
    while(A/b > 9)
    {
        n++;
        b = b * 10;
    }
    return n;
}

Console.Clear();
Console.WriteLine("Введите А ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Cifra(n));