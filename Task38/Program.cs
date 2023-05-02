// // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// // [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateRndArray(int size, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max-min) + min;
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

void PrintArray (double[] arr)
{
     for (int i = 0; i < arr.Length; i++)
     {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
     }
     Console.WriteLine();
}

double MaxMinDiff (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    double max = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    double result = max - min;
    return result;
}

double[] array = CreateRndArray(9, -99, 99);
PrintArray(array);
double diff = MaxMinDiff(array);
Console.WriteLine($"Разница между макс и мин числами = {diff}");