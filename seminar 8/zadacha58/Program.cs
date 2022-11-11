// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] MultiArray(int[,] userArray1, int[,] userArray2)
{
        int[,] resultArray = new int [userArray1.GetLength(0),userArray2.GetLength(1)];
        for (int i = 0; i < resultArray.GetLength(0) ; i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                resultArray[i,j] = 0;
                for (int x = 0; x < userArray1.GetLength(1) ; x++)
                    {
                        resultArray[i,j] = resultArray[i,j] + userArray1[i,x] * userArray2[x,j];
                    }
        }
    }
    return resultArray;
}

Console.Clear();
Console.Write("Введите количество строк в первой матрице:");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице:");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк во второй матрице:");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во второй матрице:");
int col2 = int.Parse(Console.ReadLine()!);

if(row2!=col1)
{
    Console.Write("Операция умножения матриц невозможна");
}
else
{
    int[,] userArray1 = GetArray(row1, col1, 0, 10);
    int[,] userArray2 = GetArray(row2, col2, 0, 10);
    PrintArray(userArray1);
    Console.WriteLine("-----");
    PrintArray(userArray2);
    Console.WriteLine("Результат перемножения двух матриц:");
    int[,] resultArray = MultiArray(userArray1, userArray2);
    PrintArray(resultArray);
}