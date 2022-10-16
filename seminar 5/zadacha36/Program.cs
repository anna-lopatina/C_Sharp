﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSum (int[] numArray)
{
    int sum = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if(i % 2 !=0)
        {
            sum = sum + numArray[i];
        }
    }
    return sum;
}

Console.Clear();
int[] array = GetArray(10, -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {GetSum(array)}");