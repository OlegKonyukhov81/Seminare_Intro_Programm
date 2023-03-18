// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool ValidateForMultiplication(int[,] matrixOne, int[,]matrixTwo)
{
    if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
    return true;
    else return false;
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int currentNum = 0;

    for (int k = 0; k < matrix2.GetLength(0); k++)
    {
        for (int i = 0; i < matrix2.GetLength(1); i++)
        {
            for (int j = 0; j < matrix1.GetLength(0); j++)
            {
                newMatrix[j, i] = newMatrix[j, i] + matrix2[k, i] * matrix1[j, k];
            }
        }
    }
    return newMatrix;
}

int[,] firstMatrix = Matrix(3, 2);
PrintRandomMatrix(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = Matrix(2, 3);
PrintRandomMatrix(secondMatrix);

Console.WriteLine();

if (ValidateForMultiplication(firstMatrix, secondMatrix))
{
    int[,] multiplicationMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
    PrintRandomMatrix(multiplicationMatrix);
}
else Console.WriteLine("Не соблюдается условие умножения матриц!");



