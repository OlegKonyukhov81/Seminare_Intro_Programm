// Программа, которая создает копию заданного массива с помощью поэлементного копирования.

int[] RandomArray(int num1, int num2, int num3)
{
    int[] randomArray = new int[num1];
    Random rndm = new Random();
    for (int i = 0; i < num1; i ++)
    {
        randomArray[i] = rndm.Next(num2, num3 + 1);
    }
    return randomArray;
}

void PrintRandomArray(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i]}");
        if (i < printArray.Length -1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] CopyRandomArray(int[] inputArray)
{
    int[] copyArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        copyArray[i] = inputArray[i];
    }
    return copyArray;
}

int [] randomArray = RandomArray(10, -20, 20);
PrintRandomArray(randomArray);
int[] array = CopyRandomArray(randomArray);
Console.Write("Копия массива -> ");
PrintRandomArray(array);