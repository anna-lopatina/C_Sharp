// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[] SumArray(int[,] inArray)
{
    int[] newArray = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            newArray[i] = inArray[i,j] + newArray[i];
        }
    }
    return newArray;
}

int NumberRow(int[] inArray)
{
    int a = inArray[0];
    int b = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] < a)
        {
            a = inArray[i];
            b = i;
        }
    }
    return b;
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine("----");
int x = NumberRow(SumArray(userArray));
Console.WriteLine($"Строка с минимальной суммой элементов {x}");