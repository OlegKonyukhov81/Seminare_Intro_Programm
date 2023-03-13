// Задайте массив вещественных чисел и найдите разницу между максимальным и минимальным элементами массива.
// [2.2, 2.3, 4.4, 5.5, 6.6, 7.7] -> ...


double[] RandomArrayDouble(int num1, int num2, int num3)
{
    double[] randomArray = new double[num1];
    Random rndm = new Random();
    for (int i = 0; i < num1; i ++)
    {
        randomArray[i] = rndm.NextDouble() * (num2 - num3) + num3;
        randomArray[i] = Math.Round(randomArray[i], 1, MidpointRounding.ToZero);
    }
    return randomArray;
}

void PrintRandomArray(double[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i]}");
        if (i < printArray.Length -1) Console.Write(", ");
    }
    Console.Write("]");
}

double MaxNumberSearch(double[] inputArray)
{
    double max = inputArray[0];
    for (int i = 1; i < inputArray.Length; i ++)
    if (inputArray[i] > max) max = inputArray[i];
    return max;
}

double MinNumberSearch(double[] inputArray)
{
    double min = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    if (inputArray[i] < min) min = inputArray[i];
    return min;
}
 double DifferenceOfNumbers(double num1, double num2)
 {
    double differenceNum = num1 - num2;
    return differenceNum;
 }

double[] randomArray = RandomArrayDouble(10, -9, 9);
PrintRandomArray(randomArray);
// Console.WriteLine("");
double maxNumber = MaxNumberSearch(randomArray);
// Console.WriteLine($"{maxNumber}");
double minNumber = MinNumberSearch(randomArray);
// Console.WriteLine($"{minNumber}");
double diffNumber = DifferenceOfNumbers(maxNumber, minNumber);
Console.WriteLine($" -> {diffNumber}");