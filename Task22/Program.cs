// Программа, которая на вход принимает число N а выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 5} - {index * index, 5}");
        index ++;
    }
}
Square(number);


