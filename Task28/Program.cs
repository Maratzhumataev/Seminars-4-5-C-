Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int multiNumbers = MultiNumbers(number);
Console.WriteLine(multiNumbers);

int MultiNumbers(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        multi *= i;
    }
    return multi;
}