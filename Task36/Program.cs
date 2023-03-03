// Необходимо задать массив случайных чисел и показать количество элементов стоящих на нечетных позициях.
// [.......] -> 9

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

int EvenPositionSummNum(int[] inputArray)
{
    int summNumbers = 0;
    for (int i = 1; i < inputArray.Length; i +=2)
    {
        summNumbers = summNumbers + inputArray[i];
    }
    return summNumbers;
}

int [] randomArray = RandomArray(10, -20, 20);
PrintRandomArray(randomArray);
int evenPositionSummNum = EvenPositionSummNum(randomArray);
Console.Write($" -> {evenPositionSummNum}");