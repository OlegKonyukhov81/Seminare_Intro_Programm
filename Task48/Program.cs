// Задать двумерный массив размера m x n, каждый элемент в массиве находится по формуле Аmn = m + n
// Вывести полученный массив на экран.
// 0  1  2  3
// 1  2  3  4
// 2  3  4  5

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    for (int i = 0; i < rows; i ++) // или < matrix.GetLength(0)
    {
        for (int j = 0; j < colomns; j ++)// или < matrix.GetLength(1)
        matrix[i, j] = i + j;
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

int[,] matrixArray = Matrix(3, 4);
PrintRandomArray(matrixArray);