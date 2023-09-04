// Задайте двумернный массив.Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] matrix, int firstRow, int secondRow)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[secondRow, j];
        matrix[secondRow, j] = temp;
    }

}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);

PrintMatrix(array2d);
int lastRow = array2d.GetLength(0) - 1;
ChangeRows(array2d, 0, lastRow);
PrintMatrix(array2d);



