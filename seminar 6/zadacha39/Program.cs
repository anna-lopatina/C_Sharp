// программа, кторая переворачивает одномерный массив

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];

    for (int i =0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length-1-i];
    }
    return result;
}

