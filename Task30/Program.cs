// Программа, которая выводит массив из 8 элементов, заполненный 1 и 0 в случайном порядке.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index +=1;
    }
}
void PrintArray(int[] generated)
{
    int count = generated.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(generated[position]);
        position +=1;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);