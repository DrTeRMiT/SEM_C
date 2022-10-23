// задача 22.
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов числел от 1 до N.

// 5-> 1, 4, 9, 16, 25
// 2-> 1, 4

void Table(int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index} {index*index}");
            index++;
        }

    }
    else Console.WriteLine("некорректное число");
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);