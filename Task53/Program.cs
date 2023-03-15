// Задать двумерный массив и поменять местами 1 и последнюю строку массива.

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) 
    {
        for (int j = 0; j < colomns; j ++)
        matrix[i, j] = rndm.Next(1, 20);
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

int[,] randomMatrix = Matrix(4, 5);
PrintRandomMatrix(randomMatrix);

int[,] ExchangeString(int[,] inputMatrix)
{
    int currentNum = 0;
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        currentNum = inputMatrix[0, j];
        inputMatrix[0, j] = inputMatrix[inputMatrix.GetLength(0) - 1, j];
        inputMatrix[inputMatrix.GetLength(0) - 1, j] = currentNum;
    }
    return inputMatrix;
}


int[,] exchangeStringMatrix = ExchangeString(randomMatrix);
Console.WriteLine();
PrintRandomMatrix(exchangeStringMatrix);