Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int sum = SumCalc(number);
Console.WriteLine(sum);

int SumCalc(int num)
{
    sum = 0;
    while (num > 0)
    {
        sum = sum + (num%10);
        num /= 10; 
    }
    return sum;
}