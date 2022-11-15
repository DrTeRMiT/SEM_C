// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// решение через строку:

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string DecToBin(int num)
// {
//     string result = default;
//     while (num > 0)
//     {
//         result = $"{(num % 2)}{result}";
//         num /= 2;
//     }
//     return result;
// }

// string decToBin = DecToBin(a);
// Console.WriteLine(decToBin);


// не работает???

// int ReverseNumber(int number)
// {
//     int count = 0;
//     int reverseNumber = 0;
//     while (number > 0)
//     {
//         count = number % 10;
//         reverseNumber = reverseNumber * 10 + count;
//         number /= 10;
//     }
//     return reverseNumber;
// }

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int reverseNumber = ReverseNumber(a);
// int decToBin = DecToBin(reverseNumber);
// Console.WriteLine($"Число {a} в двоичной системе = {decToBin}");


// решение через число

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int decToBin = DecToBin(num);

// Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");




// решение через рекурсию!!
// Работает !!!

int DecToBin(int dec)
{
    if (dec == 0) return 0;
    if (dec == 1) return 1;
    return DecToBin(dec / 2) * 10 + dec % 2;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int decToBin = DecToBin(num);
Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");
