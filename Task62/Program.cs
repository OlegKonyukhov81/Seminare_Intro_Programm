// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralFillMatrix(int rows, int colomns, int min)
{
    int[,] spiralFill = new int[rows, colomns];
    int currentNum = min;
    int countI = 0;
    int countJ = 0;
    while (currentNum <= rows * colomns)
    {
    for (int i = 0 + countI; i <= 0 + countI; i++)
    {
        for (int j = 0 + countJ; j < colomns - countJ; j++)
        {
            spiralFill[i, j] = currentNum;
            currentNum +=1;
        }
    }
    countI +=1;
    for (int j = colomns - 1 - countJ; j <= colomns - 1 - countJ; j++)
    {
        for (int i = 0 + countI; i < rows - countJ; i++)
        {
            spiralFill[i, j] = currentNum;
            currentNum +=1;
        }
    }
    for (int i = rows - 1 - countJ; i <= rows - 1 - countJ; i++)
    {
        for (int j = colomns - 1 - countI; j >= 0 + countJ; j--)
        {
            spiralFill[i, j] = currentNum;
            currentNum +=1;
        }
    }
    for (int j = 0 + countJ; j <= 0 + countJ; j++)
    {
        for (int i = rows - 1 - countI; i >= 0 + countI ; i--)
        {
            spiralFill[i, j] = currentNum;
            currentNum +=1;
        }
    }
    countJ ++;
    }

    return spiralFill;
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

int[,] spiralMatrix = SpiralFillMatrix(4, 4, 1);
PrintRandomMatrix(spiralMatrix);