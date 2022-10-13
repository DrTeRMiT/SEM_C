// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число №1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool ex1 = num1 > num2;
bool ex2 = num1 == num2;
bool ex3 = num1 < num2;
 
        if (ex1)
        {
            Console.WriteLine($"Число {num1} больше чем {num2}");
        }
        else if (ex2)
        {
            Console.WriteLine($"Числа {num1} и {num2} равны");
        }
        else
        {
            Console.WriteLine($"Число {num2} больше чем {num1}");
        }
