// Программа, которая задает массив из 8 элементов, заполненный псевдослучайными числами и выводит их на
// экран.

// void FillArray(int[] generated)
// {
//     int length = generated.Length;
//     int index = 0;
//     Random rndm = new Random();
//     while (index < length)
//     {
//         generated[index] = rndm.Next(0, 100);
//         index +=1;       
//     }
// }
// void PrintArray(int[] collection)
// {
//     int count = collection.Length;
//     int position = 0;
//     // Console.Write("["); лучше выводить без скобок, так будет универсальней, 
//     while (position < count)        // а скобки добавить при вызове метода. См. вызов.
//     {
//         Console.Write($"{collection[position]}");
//         if (position < count-1) Console.Write(", ");
//         position +=1;
//     }
// }

//     // Console.Write("]");

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);
// Console.Write(" -> ");
// Console.Write("[");
// PrintArray(array);
// Console.Write("]");

// То же самое, только пользователь вводит количество элементов и диапазон случайных чисел.

Console.Write("Введите количество элементов в массиве: ");
int volume = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное случайное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное случайное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayNumbers(volume, min, max);
PrintArrayNumbers(array);

int[] ArrayNumbers(int num1, int num2, int num3)
{
    Random rndm = new Random();
    int[] random = new int[num1];
    for (int i = 0; i < num1; i ++)
    {
        random[i] = rndm.Next(num2, num3 + 1);
    }
    return random;
}

void PrintArrayNumbers(int[] arrayNumbers)
{
    int length = arrayNumbers.Length;
    int count = 0;
    while (count < length)
    // for (int i = 0; i < arrayNumbers.Length; i ++)
    {
        // Console.Write(arrayNumbers[i]);
        // if (i < arrayNumbers.Length - 1) Console.Write(", ");
        Console.Write(arrayNumbers[count]);
        if (count < length - 1) Console.Write(", ");
        count ++;
    }
}