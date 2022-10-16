// Программа, которая принимает на вход число и проверяет кратно ли оно 
// одновременно 7 и 23

Console.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"{a} кратно одновременно 7 и 23");
}
else 
{
    Console.WriteLine($"{a} некратно одновременно 7 и 23");
}