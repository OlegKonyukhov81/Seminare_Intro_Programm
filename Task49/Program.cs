// Необходимо задать двумерный массив и элементы с четными индексами заменить на их квадраты.

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) // или < matrix.GetLength(0)
    {
        for (int j = 0; j < colomns; j ++)// или < matrix.GetLength(1)
        matrix[i, j] = rndm.Next(-10, 10);
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

int [,] SquareEvenIndexNum(int[,]inputMatrix)
{
    int[,] squareEvenIndex = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j ++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                squareEvenIndex[i, j] = inputMatrix[i, j] * inputMatrix[i, j];
            }
            else squareEvenIndex [i, j] = inputMatrix [i, j];
        }
    }
    return squareEvenIndex;
}

int[,] matrixArray = Matrix(5, 7);
PrintRandomArray(matrixArray);
Console.WriteLine();
int[,] evenIndexSquare = SquareEvenIndexNum(matrixArray);
PrintRandomArray(evenIndexSquare);