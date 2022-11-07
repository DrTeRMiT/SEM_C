// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Production (int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod = prod*i;
    }
    return prod;
}

Console.Write("Введие число: ");
int num = Convert.ToInt32(Console.ReadLine());

int production = Production(num);
Console.WriteLine($"Произведение числе от 1 до {num} = {production}");