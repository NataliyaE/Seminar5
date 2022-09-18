// массив с трехзначными числами. кол-во четных чисел в массиве


int[] array = new int[new Random().Next(0,20)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindCount(array));


int FindCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
            result ++;
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
        array[index] = new Random().Next(100,1000);
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

