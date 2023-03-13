// Задать двумерный массив целых чисел,
// найти среднее арифметическое каждого столбца.
// - среднее арифметическое каждого столбца: 4,4; 5,6; 3,6; 3.

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

double[] ArithmeticMeanColomns(int[,] matrix)
{
    double[] arithmeticMeanArray = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean += matrix[i, j];
        }
        arithmeticMean = arithmeticMean / matrix.GetLength(0);
        arithmeticMean = Math.Round(arithmeticMean, 1, MidpointRounding.ToZero);
        arithmeticMeanArray[j] = arithmeticMean;
    }
    return arithmeticMeanArray;
}

void PrintArithmeticMeanArray(double[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i], 5}");
        if (i != printArray.Length - 1)
        Console.Write("; ");
        else Console.Write(".");
    }
}

Console.WriteLine();
Console.Write("Среднее арифтетическое каждого столбца: ");
double[] arithmeticMeanArray = ArithmeticMeanColomns(randomMatrix);
PrintArithmeticMeanArray(arithmeticMeanArray);
