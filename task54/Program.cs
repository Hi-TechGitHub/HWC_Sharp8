// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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
            if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
void SortInDescendingOrder(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int num = 0;
        while (num < mass.GetLength(0))
        {
            for (int j = 0; j < mass.GetLength(1) - 1; j++)
            {
                if (mass[i, j] < mass[i, j + 1])
                {
                    int temp = mass[i, j];
                    mass[i, j] = mass[i, j + 1];
                    mass[i, j + 1] = temp;
                }
            }
            num++;
        }
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);
SortInDescendingOrder(matrix);
Console.WriteLine();
PrintMatrix(matrix);