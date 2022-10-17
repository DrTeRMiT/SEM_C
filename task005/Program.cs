int num = new Random().Next(10, 99);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

int firstDigit = num / 10; // 78 / 10 = 7
int secondDigit = num % 10; // 78 % 10 = 8

int res = firstDigit;
if(secondDigit > firstDigit) res = secondDigit;
Console.WriteLine($"Наибольшая цифра числа {num} = {res}");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

Console.Write($"Наибольшая цифра числа {num} = ");
Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);
