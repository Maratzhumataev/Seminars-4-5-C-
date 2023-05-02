// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRndArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
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

int OddNumbersSumCalculator(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
{
    if ((i+1) % 2 == 1) result += arr[i];
}
return result;
}

int[] array = CreateRndArray(9, -99, 99);
PrintArray(array);
int oddNumbersSum = OddNumbersSumCalculator(array);
Console.WriteLine($"Сумма чисел на нечетных позициях равна = {oddNumbersSum}");