// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
int[] MinRow(int[,] matrix)
{
    int k = 0;
    int size = matrix.GetLength(1);
    int[] min = new int[size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min[k] += matrix[i, j];
        }
        k++;
        
    }
    return min;
}
int FindMin(int[] array)
{
    int indexMin = 0;
    int min=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[i - 1])
        {
            min = array[i - 1];
            indexMin = i;
        }

    }
    return indexMin;
}
int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);
int[] a = MinRow(array2D);
int b = FindMin(a);
Console.WriteLine(b);