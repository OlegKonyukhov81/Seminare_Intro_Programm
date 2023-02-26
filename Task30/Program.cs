// Программа, которая выводит массив из 8 элементов, заполненный 1 и 0 в случайном порядке.

// void FillArray(int[] collection) 

// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2); // 0, 2 - числа, которыми заполнится массив.
//         index +=1;                           // ЗАПОМНИТЬ!(от 0 до 2)- 2 не входит в те случайные числа.       
//     }
// }
// void PrintArray(int[] generated)
// {
//     int count = generated.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(generated[position]);
//         position +=1;
//     }
// }

// int[] array = new int[8]; // {1, 2, 3, 4, 5, 6, 7, 8} 
                         // тип массива, кв. скобки говорят программе, что будет создан массив, название 
                        // массива(переменной), далее присваиваем(создаем) новый массив (ключевое слово new-
                         //- которое выделяет место памяти для массива), далее тип массива и в кв. скобках
                         // указываем количество элементов в массиве, далее в фигурных скобках можно 
                         // заполнить массив.
// FillArray(array);
// PrintArray(array);

void FillAndPrintArray(int[] generated)
{
    int length = generated.Length;
    int index = 0;
    while (index < length)
    {
        generated[index] = new Random().Next(0, 2);
        index +=1;       
    }
    int count = generated.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(generated[position]);
        position +=1;
    }
}
int[] array = new int[8];
FillAndPrintArray(array);