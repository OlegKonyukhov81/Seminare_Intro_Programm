// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите количество элементов в массиве: ");
int volume = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное случайное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное случайное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());


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
    Console.Write("[");
}

int[] freeArray = RandomArray(volume, min, max);

PrintRandomArray(freeArray);