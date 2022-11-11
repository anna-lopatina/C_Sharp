// Задайте двумерный массив. Программа, которая поменяет местами 
// первую и последнюю строку массива

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

void ChangeArray(int[,] Array)
{
    int temp = 0;
    int n = Array.GetLength(0);
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        temp = Array[0,i];
        Array[0,i] = Array[n-1,i];
        Array[n-1,i] = temp;
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
ChangeArray(userArray);
PrintArray(userArray);
