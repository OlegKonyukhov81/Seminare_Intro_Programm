// Программа, которая на вход принимает число N а выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeNum(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 6} - {index * index * index, 6}");
        index ++;
    }
}
CubeNum(number);