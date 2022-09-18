// массив со случайными числами. сумма элементов на нечетных позициях


int[] array = new int[new Random().Next(0,20)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindSum(array));


int FindSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 != 0)
       {
            result = result + array[i];
       }
    }
    return result;
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,20);
        index ++;
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}; ");
        index ++;
    }
}

