// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// bool Multipul(int number)
// {
    // while(num > 999)
    // {
    // num = num / 10;
//     return number > 99;
// }

// //не так
// // string numberText = Convert.ToString(number);

// while (true)
// {
//     num /= 10
// }

// num % 10

// bool Multipul(int number)
// {
//     return number > 100;
// }

// bool Multipul(int number)
// {
//     while(number > 999)
//     {
//     number = number / 10;
//     }
//     return number;
// }

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)
// {
//     while(num > 999)
//     {
//     num = num / 10;
//     }
//     int digit3 = num % 10;
//     Console.WriteLine($"третья цифра: {digit3}");
// }
// else
// {
//     Console.WriteLine("нет третьей цифры");
// }

int Num(int n)
{
    if (n > 99)
    {
        while (n > 999)
        {
        n = n / 10;
        }
        int digit3 = n % 10;
        return digit3;
    }
    else return -1;
}

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int number = Num(num);
Console.WriteLine(number == -1 ? "Нет третьей цифры" : $"третья цифра: {number}");