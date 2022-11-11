// Заполните спирально массив 4 на 4.

int[,] createArray(int size)
{
    int[,] resultArray = new int[size, size];
    int count = 0;
    int i = 0;
    int j = 0;
    int rowEnd = size - 1;
    int columnEnd = size - 1;
    int rowStart = 0;
    int columnStart = 0;
    bool left = true;
    bool top = true;
    while (count < size * size)
    {
        count++;
        resultArray[i, j] = count;
        //идем вправо
        if (left && top)
        {
            if (j == columnEnd)
            {
                rowStart++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //идем вниз
        if (!left && top)
        {
            if (i == rowEnd)
            {
                columnEnd--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идем влево
        if (!left && !top)
        {
            if (j == columnStart)
            {
                rowEnd--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //Идем вверх
        if (left && !top)
        {
            if (i == rowStart)
            {
                columnStart++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return resultArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] resultArray = createArray(4);
PrintArray(resultArray);
