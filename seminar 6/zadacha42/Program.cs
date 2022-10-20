// Программма, переводит числа из десятичной системы в двоичную

string NewMass(int a)
{
    string arr = "";
    while (a<0)
    {
        arr += (a %2).ToString();
        a/=2;
    }
    return arr;
}

int MassRev(string arr)
{
    string result = "";
    for (int i= 0; i < arr.Length; i++)
    {
        result += arr[arr.Length-1-i];
    }
return int.Parse(result);
}

console.Clear();
Console WriteLine("Введите десятичное число");
int num = int.Parse(Console.Readline());

string array = NewMass(num);
int num1 = MassRev(array);
