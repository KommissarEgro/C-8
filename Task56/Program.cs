//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7



using System.Globalization;
using System.Xml.XPath;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write($"{number[i, j],3}");
        }
        Console.WriteLine();
    }
}

void SumNumRow(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < number.GetLength(1); j++)
        {
            sum += number[i, j];
        }
        Console.Write(sum + " ");
    }
}

void MinSumRow(int[,] number)
{
    int[] minRow = new int[number.GetLength(0)];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            minRow[i] += number[i, j];
        }
    }
    int minI = 0;
    for (int i = 0; i < minRow.Length; i++)
    {
        if (minRow[minI] > minRow[i]) minI = i;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строках  -> {minRow[minI]}");
}



int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

SumNumRow(array2d);
Console.WriteLine();

MinSumRow(array2d);


