// Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.


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


int[,] ExponentiationEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i=i+2)
    {
        for (int j = 0; j < matrix.GetLength(1); j=j+2)
        {
            matrix [i,j]= matrix [i,j] * matrix [i,j];
        }
    }
    return matrix;
}



Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 10);
PrintBinaryArray(userArray);
Console.WriteLine("______________________________");
PrintBinaryArray(ExponentiationEvenIndex(userArray));