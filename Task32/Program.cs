// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i ++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int[] ModifiedArray(int[] inputArray)
{
    int[] explore = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i ++)
    {
        explore[i] = inputArray[i] * -1;
    }
    return explore;
}

int[] array = CreateArrayRndInt(8, -9, 9);
PrintArray(array);
Console.Write(" -> ");
int[] modifiedArray = ModifiedArray(array);
PrintArray(modifiedArray);