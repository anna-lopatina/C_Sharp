// введите n чисел, выведите числа фибоначчи до n

int[] Fib (int n)
{
    int[] array = new int [n];
    array[0] = 0;
    array[1] = 1;
    for (int i =2; i < n; i++)
    {
        array[i] = array[i-1] + array[i+2];
    }
    return array;
}

Console.Clear();
Console.WriteLine("Введите  число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = Fib(num);
Console.WriteLine(string.Join(" ", array));
