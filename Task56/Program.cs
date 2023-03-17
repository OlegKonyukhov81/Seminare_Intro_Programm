// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) 
    {
        for (int j = 0; j < colomns; j ++)
        matrix[i, j] = rndm.Next(1, 10);
    }
    return matrix;
}

void PrintRandomMatrix(int[,] printMatrix)
{
    for (int i = 0; i < printMatrix.GetLength(0); i ++)
    {
        Console.WriteLine();
        for (int j = 0; j < printMatrix.GetLength(1); j++)
        {
            Console.Write($"{printMatrix[i, j], 4}");
        }
    }
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i], 4}");
    }
}

int[] SumRowsNum(int[,] matrix)
{
    int[] sumNumRows = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumNumRows[i] = sum;
    }
    return sumNumRows;
}

int SearchMinimum(int[] exploreArray)
{
    int minNum = exploreArray[0];
    int minNumIndex = 0;
    for (int i = 1; i < exploreArray.Length; i++)
    {
        if (exploreArray[i] < minNum)
        {
            minNum = exploreArray[i];
            minNumIndex = i;
        }
    }
    return minNumIndex;
}

int[,] randomMatrix = Matrix(5, 5);
PrintRandomMatrix(randomMatrix);

Console.WriteLine();

int[] sumNumInRows = SumRowsNum(randomMatrix);
PrintArray(sumNumInRows);

Console.WriteLine();

int indexMinSum = SearchMinimum(sumNumInRows);
Console.WriteLine($"{indexMinSum} индекс строки.");