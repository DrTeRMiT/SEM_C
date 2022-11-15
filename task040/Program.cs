// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int side1, int side2, int side3)
{
    return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
}

bool isTriangle = IsTriangle(a, b, c);
Console.WriteLine(isTriangle ? "Треугольник с указанными сторонами может существовать" : "Треугольник с указанными сторонами не может существовать");