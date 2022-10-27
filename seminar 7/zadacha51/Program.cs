// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int[,] GetBinaryArray(int m, int n, int minValue, int maxValue)
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

void PrintBinaryArray(int[,] inArray)
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


int DiagonalSumm(int[,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ = summ + matrix[i,i];
    }
    return summ;
}


Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 10);
PrintBinaryArray(userArray);
DiagonalSumm(userArray);
Console.WriteLine("____________________________");
Console.WriteLine($"Cумма элементов, находящихся на главной диагонали равна : {DiagonalSumm(userArray)}");