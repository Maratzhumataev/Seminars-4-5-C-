// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет 
//  количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRndArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); 
    }
        return arr;
}

void PrintArray (int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
     {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
     }
     Console.WriteLine();
}

int EvenNumbers (int[] arr)
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCount += 1;
    }
    return evenCount;
}

int[] array = CreateRndArray(9, 0, 999);
PrintArray(array);
int result = EvenNumbers(array);
Console.WriteLine($"Количество положительных чисел = {result}");