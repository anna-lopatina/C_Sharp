// Программа, которая выводит массив из 8 элементов заполненный нулями и 
// единицами в случайном порядке

int[] RandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(0,2);   
    }
    return array;
}

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
    if (i != mass.Length - 1)
    {
        Console.Write(", ");
    }
}
}

Console.Clear();
int[] ArrayResult = RandomArray();
PrintArray(ArrayResult);

