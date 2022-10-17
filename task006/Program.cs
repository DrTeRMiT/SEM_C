// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {num}");

int firstDigit = num / 100; // 78 / 10 = 7
int secondDigit = num % 10; // 78 % 10 = 8

int number = firstDigit*10+secondDigit;

Console.WriteLine(number);