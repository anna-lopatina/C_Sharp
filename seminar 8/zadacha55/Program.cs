// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int[,] ChangeArray(int[,] userArray)
{
        int[,] resultArray = new int [userArray.GetLength(0),userArray.GetLength(1)];
        for (int i = 0; i < userArray.GetLength(0) ; i++)
        {
            for (int j = 0; j < userArray.GetLength(1); j++)
            {
                resultArray[i,j] = userArray[j,i];
            }
        }
        return resultArray;
    }

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

if(row!=col)
{
    Console.Write("Операция переворота невозможна");
}
else
{
    int[,] userArray = GetArray(row, col, 0, 10);
    PrintArray(userArray);
    ChangeArray(userArray);
    PrintArray(userArray);
}

