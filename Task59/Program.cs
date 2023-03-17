// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

void PrintArrayCoordinates(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i], 2}");
    }
}

int[] CoordinatesMinNum(int[,] matrix)
{
    int[] coordinates = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) 
            {
                min = matrix[i, j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        
        }
    }
    return coordinates;
}

int[,] WithOutRowColomn(int[,] basicMatrix, int[] rowColomn)
{
    int[,] withOutRowCol = new int[basicMatrix.GetLength(0) - 1, basicMatrix.GetLength(1) - 1];
 
    int m = 0, n = 0;

    for (int i = 0; i < withOutRowCol.GetLength(0); i++)
    {
        if (m == rowColomn[0]) m ++;

        for (int j = 0; j < withOutRowCol.GetLength(1); j++)
        {
            if (n == rowColomn[1]) n ++;
            withOutRowCol[i, j] = basicMatrix[m, n];
             n ++;
        }
        m ++;
        n = 0;
    }
    return withOutRowCol;
}

int[,] randomMatrix = Matrix(4, 4);
PrintRandomMatrix(randomMatrix);

Console.WriteLine();
int[] coordinates = CoordinatesMinNum(randomMatrix);
PrintArrayCoordinates(coordinates);

Console.WriteLine();
int[,] withOutRowCol = WithOutRowColomn(randomMatrix, coordinates);
PrintRandomMatrix(withOutRowCol);