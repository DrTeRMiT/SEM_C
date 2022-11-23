// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.



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

void ReplaceRowsColumns(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0)-1; i++)
{
for (int j = i+1; j < matrix.GetLength(1); j++)
{
// int temp = matr[i,j];
// matr[i,j] = matr[j,i];
// matr[j,i] = temp;
(matrix[i,j], matrix[j,i]) = (matrix[j,i], matrix[i,j]);

}
}
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
if (m==n)
{
ReplaceRowsColumns(array2D);
PrintMatrix(array2D);
}
else Console.WriteLine("Массив не квадратный, замена невозможна.");