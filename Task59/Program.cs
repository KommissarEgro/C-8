// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых располжен наименьший элемент масива.

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

int[] IndexesMinElenMatrix(int[,] matrix)
{
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[indexRow, indexColumn])
            {
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn };

}


int[,] DeleteCrossMinElem(int[,] matrix, int delRow, int delColumn)
{
    {
        int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int m = 0, n = 0;
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            if (m == delRow) m++;
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                if (n == delColumn) n++;
                newMatrix[i, j] = matrix[m, n];
                n++;
            }
            m++;
            n = 0;
        }
        return newMatrix;
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int[] indexesMinElem = IndexesMinElenMatrix(array2d);

int[,] resultMatrix = DeleteCrossMinElem(array2d, indexesMinElem[0], indexesMinElem[1]);
PrintMatrix(resultMatrix);