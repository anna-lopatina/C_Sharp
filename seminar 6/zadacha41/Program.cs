// Пользователь вводит с клавиатуры М чисел, посчитать сколько чисел больше 0 ввел пользователь

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

int GetCount (int[] numArray)
{
    int count = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if(numArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите массив чисел: ");
string input = Console.ReadLine();
int[] numArray = GetArrayFromString(input);
int number = GetCount(numArray);
Console.WriteLine($"Количество чисел больше 0 равно {number}");
