// Программа, котоорая принимает на входе два числа и выводит является ли второе число кратным первому.

Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
int z = b % a;
if(z == 0)
{
    Console.Write($"{b} кратно {a}");
}
else 
{
    Console.Write($"{b} некратно {a}, остаток от деления -> {z}");
}