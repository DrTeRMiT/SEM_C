// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num / 10000 % 10;
// int num2 = num / 1000 % 10;
// int num3 = num / 100 % 10;
// int num4 = num / 10 % 10;
// int num5 = num % 10;
// if (num > 9999 && num < 100000)
// {
//     if (num1 == num5 && num2 == num4)
//     {
//         Console.WriteLine("число является полиндромом");
//     }
//     else
//     {
//         Console.WriteLine("число не является полиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("число не пятизначное");
// }


// Console.Write("Введите пятизначное число: "); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// int reverse = 0; 
// while (num > 0)  
// { 
//     reverse = reverse * 10 + num % 10; 
//     num /= 10; 
// } 
// Console.WriteLine(reverse);
// if (num == reverse)
// {
//     Console.WriteLine("это число является полиндромом");
// }
// else
// {
//     Console.WriteLine("это число не является полиндромом");
// }