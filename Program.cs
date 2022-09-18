// // массив вещественных чисел. найти разницу между максимальных и минимальным значением


double[] array = new double[new Random().Next(0,20)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"diff = {FindDiff(array)}");


int FindDiff(double[] array)
{
    double max = array[0];
    double min = array[0];    
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
       if (min > array[i])
       {
            min = array [i];
       }
    }
    Console.WriteLine($"min = {min}");

    for (int i = 1; i < array.Length; i++)
    {
       if (max < array[i])
       {
            max = array [i];
        }
    }
    Console.WriteLine($"max = {max}");
    Console.WriteLine();
    
    result = Convert.ToInt32(max - min);
    return result;
}

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,20);
        index ++;
    }
}

void PrintArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}; ");
        index ++;
    }
}

