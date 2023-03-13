// Задать двумерный массив целых чисел,
// найти среднееарифметическое каждого столбца.
// - среднееарифметическое каждого столбца: 4,4; 5,6; 3,6; 3.

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

void PrintRandomMatrix(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i ++)
    {
        Console.WriteLine();
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j], 4}");
        }
    }
}

int[,] randomMatrix = Matrix(4, 5);
PrintRandomMatrix(randomMatrix);

double[] ArithmeticMeanColomns(int[,] matrix)
{
    double[] arithmeticMeanArray = new double[matrix.GetLength(1)];
    double arithmeticMean = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + matrix[i, j];
        }
        arithmeticMean = arithmeticMean / matrix.GetLength(0);
        
    }
}
