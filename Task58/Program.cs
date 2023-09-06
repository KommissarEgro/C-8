// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


using System.Globalization;

int[,] CreateMatrix(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
             Console.Write(String.Format("{0,3}",matrix[i, j]));
            else Console.WriteLine(String.Format("{0,3}",matrix[i, j]));
        }
    }
}

int[,] ComposMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
   int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;

                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
    }
    return resultMatrix;
}

int[,] firstMatrix = CreateMatrix(2,2,1,9);
int[,] secondMatrix = CreateMatrix(2,2,1,9);
PrintMatrix(firstMatrix);
Console.WriteLine();

PrintMatrix(secondMatrix);
Console.WriteLine();

PrintMatrix(ComposMatrix(firstMatrix, secondMatrix));