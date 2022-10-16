// Программа, которая принимает на вход два числа и проверяет является ли одно квадратом другого

Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

if(a == b * b || b == a * a)
{
    Console.WriteLine($"Да, одно из чисел является квадратом второго");
}
else 
{
    Console.WriteLine($"Нет, ни одно из чисел не является квадратом второго");
}