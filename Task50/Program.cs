// Программа, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение элемента или же, что его нет.
// 1 3 4 5 6
// 1 2 3 4 5
// 1 2 3 4 5
// 1, 7 -> такого элемента нет

Console.Write("Введите строку элемента: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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

// bool ValidateCoordinate(int[,] inputMatrix, int row, int colomn)
// {
//     if (row > 0 && row <= inputMatrix.GetLength(0) && colomn > 0 && colomn <= inputMatrix.GetLength(1))
//     {
//         return true;
//     }
//     else return false;
// }

// int SearchNumber(int[,] inputMatrix, int row, int colomn)
// {
//     return inputMatrix[row - 1, colomn - 1];
// }


// Console.WriteLine();
// if (ValidateCoordinate(randomMatrix, num1, num2))
// {
//     int searchNumber = SearchNumber(randomMatrix, num1, num2);
//     Console.WriteLine($"{num1}, {num2} -> {searchNumber}");
// }
// else Console.WriteLine("Такого элемента в массиве нет!");

void SearchNumber(int[,] inputMatrix, int row, int colomn)
{
    Console.WriteLine();

    if (row > 0 && row <= inputMatrix.GetLength(0) && colomn > 0 && colomn <= inputMatrix.GetLength(1))
    {
        Console.WriteLine($"{row}, {colomn} -> {inputMatrix[row - 1, colomn - 1]}");
    }
    else Console.WriteLine($"{row}, {colomn} -> Такого элемента в массиве нет!");
}

SearchNumber(randomMatrix, num1, num2);
