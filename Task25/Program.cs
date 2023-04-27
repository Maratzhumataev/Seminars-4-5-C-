// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int numToDegree = NumToDegree( number1, number2);
Console.WriteLine(numToDegree);

int NumToDegree(int num1, int num2)
{
    int multiplication = num1;
    for (int i = 1; i < num2; i++)
    {
        multiplication = multiplication * num1;           
    }
    return multiplication;
}