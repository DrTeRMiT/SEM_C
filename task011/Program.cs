Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while(num > 999)
    {
    num = num / 10;
    }
    int digit3 = num % 10;
    Console.WriteLine($"третья цифра: {digit3}");
}
else
{
    Console.WriteLine("нет третьего числа");
}