// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {num}");

int firstDigit = num / 100; 
int secondDigit = num % 10; 

int number = firstDigit*10+secondDigit;

Console.WriteLine(number);

// int FirstLastNumber(int number)
// {
//     int firstNumber = number / 100;
//     int lastNumber = number % 10;
//     return firstNumber*10 + lastNumber;
// }

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// Console.WriteLine(FirstLastNumber(num));
