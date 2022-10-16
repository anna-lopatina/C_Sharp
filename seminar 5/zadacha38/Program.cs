// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int GetMax (int[] numArray)
{
    int max = numArray[0];
    for (int i = 0; i < numArray.Length; i++)
    {
        if(numArray[i] > max)
        {
            max = numArray[i];
        }
    }
    return max;
}
int GetMin (int[] numArray)
{
    int min = numArray[0];
    for (int i = 0; i < numArray.Length; i++)
    {
        if(numArray[i] < min)
        {
            min = numArray[i];
        }
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine();
int[] InputArray = GetArrayFromString(input);
int razn = GetMax(InputArray) - GetMin(InputArray);
Console.WriteLine($"Разница между макисмальным и минимальным элементом массива равна {razn}");
