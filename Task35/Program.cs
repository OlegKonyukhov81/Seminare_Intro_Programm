// Программа, которая создает одномерный массив из 123 случайных и находит количество элементов в массиве
// со значением от 10 до 99.
// [1, 123, 3, 4, 5] -> 1
// [61, 71, 32, 62] -> 4

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

int ExploreArray(int[] random)
{
    int count = 0;
    for (int i = 0; i < random.Length; i ++)
    {
        if (random[i] > 9 && random[i] < 100)
        count = count + 1;
    }
    return count;
}

int[] array = RandomArray(23, 1, 500);
PrintRandomArray(array);
int countNum = ExploreArray(array);
Console.Write($" -> {countNum}");