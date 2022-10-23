// // 14. Напишите программу, которая принимает на
// // вход число и проверяет, кратно ли оно
// // одновременно 7 и 23.
// // 14 -> нет
// // 46 -> нет
// // 161 -> да

// // Console.WriteLine("Введите целое положительное число:");
// // int num = Convert.ToInt32(Console.ReadLine());
// // int a = 7;
// // int b = 23;

// // Console.WriteLine((Multiple(num, a) && Multiple(num, b)) ? "да" : "нет");


// // bool Multiple(int first, int second)
// // {
// //     return first % second == 0;
// // }


// bool Multipul(int number)
// {
//     return number % 7 ==0 && number % 23 == 0;
// }

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool multipul = Multipul(num);

// Console.Write(multipul?"Кратно":"Не кратно");

// // 16. Напишите программу, которая принимает на
// // вход два числа и проверяет, является ли одно
// // число квадратом другого.
// // 5, 25 -> да
// // -4, 16 -> да
// // 25, 5 -> да
// // 8,9 -> нет


// bool Square(int number1, int number2)
// {
//     return number1 * number1 == number2 || number2 * number2 == number1;

// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool square = Square(num1, num2);

// Console.Write(square?"Да":"Нет");

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (num > 100) num = num / 10;
}

int numD3 = num % 10;

Console.WriteLine(numD3);