﻿int[] array = CreateArrayRndInt(8, -99, 99);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
     Random rnd = new Random();
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
}