// Задать двумерный массив, заменить строки на столбцы. 
// В случае если это не возможно(не квадрат), программа выводит сообщение для пользователя.

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) 
    {
        for (int j = 0; j < colomns; j ++)
        matrix[i, j] = rndm.Next(0, 10);
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

bool ValidateSquareMatrix(int[,] inputMatrix)
{
    if (inputMatrix.GetLength(0) == inputMatrix.GetLength(1))
    return true;
    else return false;
}

int[,] ChangeRowsOnColomns(int[,] inputMatrix)
{
    
    for (int i = 0; i < inputMatrix.GetLength(0); i ++)
    {
        int currentNum = 0;
        int count = 1;
        while (count + i < inputMatrix.GetLength(0))
        {
            currentNum = inputMatrix[i, i + count];
            inputMatrix[i, i + count] = inputMatrix[i + count, i];
            inputMatrix[i + count, i] = currentNum;
            count ++;
        }
    }
    return inputMatrix;
}

int[,] randomMatrix = Matrix(5, 5);
Console.WriteLine();
if (ValidateSquareMatrix(randomMatrix))
{
    PrintRandomMatrix(randomMatrix);
    Console.WriteLine();
    int[,] changeRowsOnColomns = ChangeRowsOnColomns(randomMatrix);
    PrintRandomMatrix(changeRowsOnColomns);
    Console.WriteLine();
}
else  Console.WriteLine("Количество строк должно быть равно количеству столбцов!");
Console.WriteLine();

