// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void ReplaceFirstLastRows(int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
int temp = matrix[0, j];
matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
matrix[matrix.GetLength(0) - 1, j] = temp;
}
}



Console.Write("Введите количество строк массива: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n= ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceFirstLastRows(array2D);
PrintMatrix(array2D);