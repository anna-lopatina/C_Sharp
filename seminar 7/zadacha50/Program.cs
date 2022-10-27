// Напишите программу, которая на вход принимает число и возвращает индексы элемента в 
// двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next();
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
    
}

(int, int, bool) CheckArray(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == value) 
            {
                return (i, j, true);
            }
        }
    }
    return (-1,-1, false);
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int n = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(m, n);
PrintArray(userArray);

Console.WriteLine("Введите искомое число: ");
int x = int.Parse(Console.ReadLine()!);

int iCoord,jCoord;
bool isElementPresent;
(iCoord, jCoord, isElementPresent) = CheckArray(userArray, x);

if (isElementPresent) 
{
    Console.WriteLine($"Такое число в массиве есть, его индексы: i={iCoord}, j={jCoord}");
} 
else 
{
    Console.WriteLine("Такого числа в массиве нет");
}
