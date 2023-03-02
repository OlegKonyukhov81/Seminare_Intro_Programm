// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов в массиве: ");
int volume = Convert.ToInt32(Console.ReadLine());

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

int[] MultiplicCoupleNumbers(int[] inputArray)
{
    int lengthNewArray = inputArray.Length / 2;
    
    if (inputArray.Length % 2 != 0) lengthNewArray +=1;

    int[] multiplicCoupleNum = new int[lengthNewArray];
    
    for (int i = 0; i < lengthNewArray; i++)
    {
        if (i != inputArray.Length - 1 - i)
        {
            multiplicCoupleNum[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        }
        else multiplicCoupleNum[i] = inputArray[i];
    }
    return multiplicCoupleNum;
}
    
// Отдельными методами (не доделал)

// int[] MultiplicNumEvenArray(int[] inputArray)
// {
//     int newlength = inputArray.Length / 2;
//     int[] multiplicCoupleNum = new int[newlength];
//     for (int i = 0; i < newlength; i++)
//     {
//         multiplicCoupleNum[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
//     }
//     return multiplicCoupleNum;
// }
// int[] MultiplicNumOddArray(int[] inputArray)
// {
//     int newlength = inputArray.Length / 2 + 1;
//     int[] multiplicCoupleNum = new int[newlength];
//     for (int i = 0; i < newlength - 1; i++)
//     if (inputArray[i] == inputArray[inputArray.Length - 1 - i])
//     {
//         multiplicCoupleNum[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
//     }
//     return multiplicCoupleNum;
// }

int[] newArray = RandomArray(volume, 1, 100);
PrintRandomArray(newArray);
Console.Write(" -> ");
int[] modifiedArray = MultiplicCoupleNumbers(newArray);
PrintRandomArray(modifiedArray);
