// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите количество элементов в массиве: ");
// int volume = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное случайное число массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное случайное число массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число: ");
int searchNum = Convert.ToInt32(Console.ReadLine());


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

// int PositiveFind(int[] explore, int searchableNum)
// {
//     for (int i = 0; i < explore.Length; i ++)
//     {
//         if (explore[i] == searchableNum)
//         {
//             return searchableNum;
//         }
//         else break;
//     }

// }
void NegativeFind(int[] explore, int searchableNum)
{
    int cloudNum = 1;
    for (int i = 0; i < explore.Length; i ++)
    {
        if (explore[i] == searchableNum)
        {
            Console.Write(" -> Да ");
            break;
        }
        else
        {
            cloudNum = cloudNum + 1;
        }
        if (cloudNum == explore.Length - 1)
    {
        Console.Write(" -> Нет ");
    }
    }
}

Console.Write($"{searchNum}; массив ");
int[] freeArray = RandomArray(10, -10, 10);

PrintRandomArray(freeArray);
// PositiveFind(freeArray, searchNum);
NegativeFind(freeArray, searchNum);