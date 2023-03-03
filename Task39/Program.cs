// Программа, которая разворачивает одномерныймассив [1 2 3 4 5] -> [5 4 3 2 1]

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

// int[] ReversalOfArray(int[] inputArray)
// {
//     int[] reversalOfArray = new int[inputArray.Length];
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (i != inputArray.Length - 1 - i)
//         reversalOfArray[i] = inputArray[inputArray.Length - 1 - i];
//         else reversalOfArray[i] = inputArray[i];
//     }
//     return reversalOfArray;
// }

int [] randomArray = RandomArray(10, -20, 20);
PrintRandomArray(randomArray);
Array.Reverse(randomArray);
Console.Write(" -> ");
PrintRandomArray(randomArray);
// int[] reversalArray = ReversalOfArray(randomArray);
// Console.Write(" -> ");
// PrintRandomArray(reversalArray);

