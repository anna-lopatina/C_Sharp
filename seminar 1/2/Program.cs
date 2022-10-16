// Напишите программу, которая на вход принимает трехзначное число, на выходе - последняя цифра.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");

