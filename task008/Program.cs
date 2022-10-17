// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num / 10; 
int secondDigit = firstDigit % 10; 

Console.WriteLine(secondDigit);