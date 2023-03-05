// Программа, которая преобразовывает десятичное число в двоичное.
// 45 -> 101101


// int NumberLength(int exploreNum)
// {
//     int count = 0;
//     int workNum = exploreNum;
//     while (workNum != 0)
//     {
//         workNum = workNum / 2;
//         count +=1;
//     }
//     return count;
// }

// int[] ConvertInBinarySystem(int lengthArray, int exploreNum)
// {
//     int[] convertInBinary = new int[lengthArray];
//     // int currentNum = exploreNum;
//     for (int i = lengthArray - 1; i >= 0; i -=1)
//     {
//         convertInBinary[i] = exploreNum % 2;
//         exploreNum = exploreNum / 2;
//     }
//     return convertInBinary;
// }

// void PrintRandomArray(int[] printArray)
// {
//     for (int i = 0; i < printArray.Length; i ++)
//     {
//         Console.Write($"{printArray[i]}");
//     }
// }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int numberLength = NumberLength(number);
// // Console.Write($"{numberLength}");
// int[] binaryNumber = ConvertInBinarySystem(numberLength, number);
// Console.Write($"{number} -> ");
// PrintRandomArray(binaryNumber);

// ИЛИ

int ConvertToBinary(int decNum)
{
    int count = 1;
    int result = 0;
    while (decNum > 0)
    {
        result = result + decNum % 2 * count;
        decNum = decNum / 2;
        count *=10;
    }
    return result;
}
int binNum = ConvertToBinary(number);
Console.Write($"{number} -> {binNum} ");

// или через строку

// string ConvertInBinarySystem(int num)
// {
//     string numberBinary = string.Empty;
//     while (num > 0)
//     {
//         numberBinary = num % 2 + numberBinary; // от перемены мест слагаемых, 
//         num = num / 2;                         // меняется их расположение в рельтате(ответе).
//     }
//     return numberBinary;
// }

// string convertInBinary = ConvertInBinarySystem(number);
// Console.Write(convertInBinary);