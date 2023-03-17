// Задать двумерный массив и написать программу,
// которая упорядочит по убыванию элементы каждой строки массива.

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

int[,] DescendingSort(int[,] matrix)
{
    int currentNum = 0;
    int count = matrix.GetLength(1); // для читаемости
    for (int k = 1; k < count; k ++)
    {
        for (int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j ++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    currentNum = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = currentNum;
                }
            }
        }
    }
    return matrix;
}

int[,] randomMatrix = Matrix(5, 5);
PrintRandomMatrix(randomMatrix);

Console.WriteLine();

int[,] matrixDescendingRows = DescendingSort(randomMatrix);
PrintRandomMatrix(matrixDescendingRows);