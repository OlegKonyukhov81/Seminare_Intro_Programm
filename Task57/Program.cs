// Составить частотный словарь элементов двумерного массива.
// Словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1 2 3 
// 4 5 6
// 1 2 3
// 1 встречается 2 раза
// 2 встречается 2 раза
// 3 встречается 2 раза
// 4 встречается 1 раз
// 5 встречается 1 раз
// 6 встречается 1 раз
// ПОДСКАЗКА!! Двумерн массив надо преобразовать в одномерный! Далее сделать сортировку!!
// Array.Sort(array); - только для одномерного массива!!

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

int[,] randomMatrix = Matrix(4, 4);
PrintRandomMatrix(randomMatrix);

int[] ConvertMatrixInArray(int[,] inputMatrix)
{
    int[] array = new int[inputMatrix.GetLength(0) * inputMatrix.GetLength(1)]; // или [inputMatrix.Length]
    int position = 0;

        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
           {
              array[position] = inputMatrix[i, j];
              position ++;
           } 
        //    position ++; ТАК не ДЕЛАТЬ!!!
        }
    return array;
}

void PrintConvertMatrix(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i], 2}");
    }
}

Console.WriteLine();
int[] convertMatrix = ConvertMatrixInArray(randomMatrix);
Array.Sort(convertMatrix);
PrintConvertMatrix(convertMatrix);

void Counting(int[] exploreArray)
{
    int count = 1;
    int currentNum = exploreArray[0];
    for (int i = 1; i < exploreArray.Length; i++)
    {
        if (exploreArray[i] == currentNum)  count ++;
        else
        {
            Console.WriteLine($"{currentNum} -> {count} раз.");
            currentNum = exploreArray[i];
            count = 1;
        } 
    }
    Console.WriteLine($"{currentNum} -> {count} раз.");
}



Console.WriteLine();

Counting(convertMatrix);