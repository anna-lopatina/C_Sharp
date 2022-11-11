// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int z = 0;
            while (z < k)
            {
                int a = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, a)) continue;
                result[i, j, z] = a;
                z++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] InArray, int element)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            for (int z = 0; z < InArray.GetLength(2); z++)
            {
                if (InArray[i, j, z] == element) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Console.Write($"{Array[i, j, z]} ({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите количество элементов в первом измерении массива:");
int dimensionOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество элементов во втором измерении массива:");
int dimensionTwo = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество элементов в третьем измерении массива:");
int dimensionThree = int.Parse(Console.ReadLine()!);

int[,,] userArray = GetArray(dimensionOne, dimensionTwo, dimensionThree, 10, 98);
PrintArray(userArray);

