﻿// Пользователь сначала вводит количество М чисел. Затем вводит сами числа,
// нужно посчитать сколько чисел > 0 ввел пользователь.
// -1, -2, -3, 4, 5, 6 -> 3

Console.Write("Количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());



int[] RandomArray(int arrayLength)
{
    int[] randomArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i ++)
    {
        Console.Write($"Введите число массива под идексом {i} : ");
        int curretNum = Convert.ToInt32(Console.ReadLine());
        randomArray[i] = curretNum;
    }
    return randomArray;
}

void PrintRandomArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i]}");
        if (i < printArray.Length -1)
        Console.Write(", "); 
    }
}

int[] random = RandomArray(number);
PrintRandomArray(random);

int CountPositiveNum(int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0) count +=1;
    }
    return count;
}

int countPositiveNum = CountPositiveNum(random);
// Console.WriteLine();
Console.Write($" -> {countPositiveNum} чисел(а) > 0");


