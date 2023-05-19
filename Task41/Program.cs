// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите числа");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int FindPosNumbers (int[] arr)
{   
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
     {
        if(arr[i] > 0) count++;
     }
    return count;
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

Console.WriteLine("Введите M чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
int countOfPositNum = FindPosNumbers(array);
Console.WriteLine($"Количество чисел больше 0-> {countOfPositNum}");
PrintArray(array);