// Необходимо задать массив случайных трехзначных чисел и показать количество четных чисел.
// [.......] -> 2


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

int EvenNumbersCount(int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i ++)
    {
        if (inputArray[i] % 2 == 0) count +=1;
    }
    return count;
}

int [] randomArray = RandomArray(10, 100, 999);
PrintRandomArray(randomArray);

int evenNumbersCount = EvenNumbersCount(randomArray);
Console.Write($" -> {evenNumbersCount}");
