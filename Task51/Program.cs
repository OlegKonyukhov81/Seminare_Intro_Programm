// Задать двумерный массив, найти сумму элементов, находящихся на главной диагонали
// т.е (0,0) (1,1) (2,2) и т.д
//  40 33  3 30 29 10 24 38  1 36
//   7  1 29 28  2 22 39 41 24 39
//  26 18 28 37  8 24 29 14 39  2
//   9 15  8 33 31  7 30 11  8 31
// Сумма элементов главной диагонали.40 + 1 + 28 + 33 = 102

int[,] Matrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rndm = new Random();
    for (int i = 0; i < rows; i ++) // или < matrix.GetLength(0)
    {
        for (int j = 0; j < colomns; j ++)// или < matrix.GetLength(1)
        matrix[i, j] = rndm.Next(1, 50);
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

// int[] DiagonaleNumbers(int[,] exploreMatrix)
// {
//     if (exploreMatrix.GetLength(0) < exploreMatrix.GetLength(1))
    
//     {
//         int[] diagonalNum = new int[exploreMatrix.GetLength(0)];
//         for (int i = 0; i < exploreMatrix.GetLength(0); i ++)
//         {
//             for (int j = 0; j < exploreMatrix.GetLength(0); j++)
//             {
//                 if (i == j)
//                 {
//                     diagonalNum[i] = exploreMatrix[i, j];
//                 }
//             }
//         }
//         return diagonalNum;
//     }
//     else
//     {
//         int[] diagonalNum = new int[exploreMatrix.GetLength(1)];
//         for (int i = 0; i < exploreMatrix.GetLength(1); i ++)
//         {
//             for (int j = 0; j < exploreMatrix.GetLength(1); j++)
//             {
//                 if (i == j)
//                 {
//                     diagonalNum[i] = exploreMatrix[i, j];
//                 }
//             }
//         }
//         return diagonalNum;
//     }
// }

// void PrintMainDiagNumArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//     {
//         Console.Write($"{array[i]} ");
//         if (i == array.Length - 1)
//         Console.Write("");
//         else Console.Write("+ ");
//     }
//     Console.Write("= ");
// }

// ИЛИ

void PrintMainDiagonalNum(int[,] inputMatrix)
{
    if (inputMatrix.GetLength(0) < inputMatrix.GetLength(1)) 

    { // Если (inputMatrix.GetLength(0) = inputMatrix.GetLength(1) метод считает по else!

        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
        //for (int j = 0; j < inputMatrix.GetLength(0); j++)
        //{
            //if (i == j)
            //{
                // для оптимизации и быстроты работы убираем доп. циклы!!!
                // то же надо делать и для методов выше!!!
            Console.Write(inputMatrix[i, i]);
            if (i != inputMatrix.GetLength(0) - 1)
            {
                Console.Write(" + ");
            }
            else Console.Write("");
            }
        //}
        //}
        Console.Write(" = ");
    }
    else
    {
       for (int i = 0; i < inputMatrix.GetLength(1); i++)
        {
        // for (int j = 0; j < inputMatrix.GetLength(1); j++)
        // {
           // if (i == j)
           // {
            Console.Write(inputMatrix[i, i]);
            if (i != inputMatrix.GetLength(1) - 1)
            {
                Console.Write(" + ");
            }
            else Console.Write("");
            }
        //}
        //}
        Console.Write(" = ");
    }
}

int SumMainDiagonal(int[,] inputMatrix)
{
    int sumNumbers = 0;
    int count = inputMatrix.GetLength(0); // переменная для интервала счетчика
    if (inputMatrix.GetLength(0) > inputMatrix.GetLength(1))
    count = inputMatrix.GetLength(1);

// Или в for добавляем ограничение для i и верхние 3 строчки не нужны!!!

    for (int i = 0; i < inputMatrix.GetLength(0) && i < inputMatrix.GetLength(1); i++)
    {
        //for (int j = 0; j < inputMatrix.GetLength(1); j++)
        //{
            //if (i == j) 
            sumNumbers += inputMatrix[i, i];
        //}
    }
    return sumNumbers;
}

int[,] randomMatrix = Matrix(4, 4);
PrintRandomArray(randomMatrix);
Console.WriteLine();

Console.Write("Сумма элементов главной диагонали.");

PrintMainDiagonalNum(randomMatrix);

// int[] mainDiagonalNum = DiagonaleNumbers(randomMatrix);
// PrintMainDiagNumArray(mainDiagonalNum);

int sumNumMainDiagonale = SumMainDiagonal(randomMatrix);
Console.Write(sumNumMainDiagonale);
