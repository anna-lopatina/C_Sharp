// программа, которая принимает на вход три числа и проверяет может ли существовать
// треугольник с сторонами такой длины

bool IsTriangle (int a, int b, int c)
{
    return a < b + c && b < c + a && c < b + a;
}

int[] array = new int[3];

for (int i = 0; i < 3; i ++)
{
    array[i] = int.Parse(Console.Readline()!);
}

if (IsTriangle(array[0], array[1], array[2]))
{
    Console.WriteLine("+");
}
else
{
     Console.WriteLine("-");
}
