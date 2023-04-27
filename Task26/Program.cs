// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int digitCount = DigitCount(number);
Console.WriteLine (digitCount);

int DigitCount (int num)
{
    int digit = 0;
    while (num > 0)
    {
    num = num / 10;
    digit += 1;
    }
    return digit;
}