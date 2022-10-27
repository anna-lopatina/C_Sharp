// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArraySingle(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{Math.Round(inArray[i], 1)}\t");
    }
}

double[] SredneeArifm(int[,] matrix, int row, int col)
{
    int[] summ = new int[col];
    double[] srednee = new double[col];
    for (int j = 0; j < col; j++)
    {
        for (int i = 0; i < row; i++)
        {
            summ[j] = summ[j] + matrix[i,j];
        }
        srednee[j] = Convert.ToDouble(summ[j]) / Convert.ToDouble(row);
    }
    return srednee;
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
double[] SA = SredneeArifm(userArray, row, col);
Console.WriteLine("____________________________");
Console.Write($"Среднее арифметическое элекментов в каждом столбце : ");
PrintArraySingle(SA);