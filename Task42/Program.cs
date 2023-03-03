// Программа, которая преобразовывает десятичное число в двоичное.
// 45 -> 101101


int NumberLength(int exploreNum)
{
    int count = 0;
    int workNum = exploreNum;
    while (workNum != 0)
    {
        workNum = workNum / 2;
        count +=1;
    }
    return count;
}

int[] ConvertInBinarySistem(int lengthArray, int exploreNum)
{
    int[] convertInBinary = new int[lengthArray];
    int currentNum = exploreNum;
    for (int i = lengthArray - 1; i >= 0; i -=1)
    {
        convertInBinary[i] = currentNum % 2;
        currentNum = currentNum / 2;
    }
    return convertInBinary;
}

void PrintRandomArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i]}");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberLength = NumberLength(number);
// Console.Write($"{numberLength}");
int[] binaryNumber = ConvertInBinarySistem(numberLength, number);
Console.Write($"{number} -> ");
PrintRandomArray(binaryNumber);