// Задайте двумерный массив m x n, заполненный случайными целыми числами. m=3, n=4.

int[,] RandomArray(int rows, int colomns, int min, int max)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) // или < matrix.GetLength(0)
    {
        for (int j = 0; j < colomns; j ++)// или < matrix.GetLength(1)
        matrix[i, j] = rndm.Next(min, max + 1);
    }
    return matrix;
}

void PrintRandomArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i ++)
    {
        Console.WriteLine();
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j], 3}");
        }
    }
}

int[,] matrixArray = RandomArray(3, 4, -50, 50);
PrintRandomArray(matrixArray);