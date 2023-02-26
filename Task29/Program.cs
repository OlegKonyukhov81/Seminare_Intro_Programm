// Программа, которая задает массив из 8 элементов, заполненный псевдослучайными числами и выводит их на
// экран.

void FillArray(int[] generated)
{
    int length = generated.Length;
    int index = 0;
    Random rndm = new Random();
    while (index < length)
    {
        generated[index] = rndm.Next(0, 100);
        index +=1;       
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    // Console.Write("["); лучше выводить без скобок, так будет универсальней, 
    while (position < count)        // а скобки добавить при вызове метода. См. вызов.
    {
        Console.Write($"{collection[position]}");
        if (position < count-1) Console.Write(", ");
        position +=1;
    }
}

    // Console.Write("]");

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
Console.Write("[");
PrintArray(array);
Console.Write("]");
