// Задать двумерный массив, заполненный случайными вещественными числами
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9

double[,] MatrixDoubleRandom(int rows, int colomns, int min, int max)
{
    double[,] matrix = new double[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) // или < matrix.GetLength(0)
    {
        for (int j = 0; j < colomns; j ++)// или < matrix.GetLength(1)
        { 
            matrix[i, j] = rndm.NextDouble() * (min - max) + max;
            matrix[i, j] = Math.Round(matrix[i, j], 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}

void PrintRandomMatrix(double[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i ++)
    {
        Console.WriteLine();
        Console.Write("[");
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j], 6}");
        }
        Console.Write(" ]");
    }
    Console.WriteLine();
}

double[,] matrixDoubleRandom = MatrixDoubleRandom(3, 4, -9, 9);
PrintRandomMatrix(matrixDoubleRandom);
Console.WriteLine();
