// Программа принимает на вход число А и выдает сумму чисел от 1 до А

int GetSum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите А ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n));
