// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] OrdinaryArray(int[,] Array)
{
    int n = 0;
    int[] newArray = new int[Array.GetLength(0)*Array.GetLength(1)];
        for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            newArray[n++] = Array[i,j];
        }
    }
    return newArray;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}

void CountInArray (int[] inArray)
{
    int count = 0;
    int etalon = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i] == etalon)
        {
            count+=1;
        }
        else
        {
            
            Console.WriteLine($"Число {etalon} встречается {count} раз");
            etalon = inArray[i];
            count = 1;
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

int[] array1D = OrdinaryArray(userArray);
SortArray(array1D);
CountInArray(array1D);

