// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortBinaryArray(int[,] inArray)
{
    for (int x = 0; x < inArray.GetLength(0); x++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
    {
            for (int j = i+1; j < inArray.GetLength(1); j++)
            {
                if(inArray[x,i]<inArray[x,j])
                {
                    int k=inArray[x,i];
                    inArray[x,i]=inArray[x,j];
                    inArray[x,j]=k;
                }
            }
    }
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine("Отсортированный массив:");
SortBinaryArray(userArray);
PrintArray(userArray);