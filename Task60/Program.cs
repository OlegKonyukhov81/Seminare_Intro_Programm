// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество аппликат: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[,,] Matrix3D(int rows, int colomns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, colomns, depth];
    int currentNum = min;

    for (int i = 0; i < rows; i ++) 
    {
        for (int j = 0; j < colomns; j ++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = currentNum;
                currentNum +=1;
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] printMatrix)
{
    for (int i = 0; i < printMatrix.GetLength(0); i ++)
    {
        Console.WriteLine();
        for (int j = 0; j < printMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < printMatrix.GetLength(2); k++)
            {
                Console.Write($"{printMatrix[i, j, k], 4}({i},{j},{k})");
            }
        }
    }
}

bool ValidateMatrix3D(int rows, int colomns, int depth)
{
    int volumeMatrix = 89;
    if (rows * colomns * depth < volumeMatrix)
    return true;
    else return false;
}

if (ValidateMatrix3D(num1, num2, num3))
{
    int [,,] matrix3D = Matrix3D(num1, num2, num3, 10, 100);
    PrintMatrix3D(matrix3D);
}
else Console.WriteLine("Невозможно создать из неповторяющихся двухзначных чисел!");