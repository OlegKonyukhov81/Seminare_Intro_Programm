//  Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i ++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
// создаем новую переменную(массив)- результат работы метода CreateArrayRndInt(12, -9, 9)
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
// создаем новую переменную(массив)- результат работы метода SumPositiveNegativeElem(array)
int[] devidedArray = SumPositiveNegativeElem(array);
Console.WriteLine(); // разделительная пустая полоса
Console.WriteLine($"Сумма положительных чисел = {devidedArray[0]}");
Console.WriteLine($"Сумма отрицательных чисел = {devidedArray[1]}");


// SumPositiveNegativeElem(array); (вызов void)

// Метод void

// void SumPositiveNegativeElem(int[] randomArr)
// {
//     int sumPositiveNum = 0;
//     int sumNegativeNum = 0;
//     for (int i = 0; i < randomArr.Length; i ++)
//     {
//         if (randomArr[i] >= 0) sumPositiveNum += randomArr[i];
//         else sumNegativeNum += randomArr[i];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма положительных = {sumPositiveNum}");
//     Console.WriteLine($"Сумма отрицательных = {sumNegativeNum}");
// }

// Метод int (возвращаемый)

int[] SumPositiveNegativeElem(int[] randomArr)
{
    int sumPositiveNum = 0;
    int sumNegativeNum = 0;
    for (int i = 0; i < randomArr.Length; i ++)
    {
        if (randomArr[i] >= 0) sumPositiveNum += randomArr[i];
        else sumNegativeNum += randomArr[i];
    }
    return new int[]{sumPositiveNum, sumNegativeNum};
}











// int[] GetSumPositiveNegativeElem()
// {
//     int sumNegative = 0;
//     int sumPositive = 0;
//     for (int i = 0; i < arr.Length; i ++)
//     {
//         if (arr[i] < 0) sumNegative += arr[i];
//         else sumPositive += arr[i];
//     }
//     return new int[]{sumNegative, sumPositive};
// }
// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"Сумма положительных чисел = {sumPositiveNegativeElem[1]}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumPositiveNegativeElem[0]}");
