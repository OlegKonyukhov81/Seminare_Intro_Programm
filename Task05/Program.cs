// Программа, которая на вход принимает число N
// на выходе показывает все целые числа в промежутке от -N до N
// 4 -> -4 -3 -2 -1 0 1 2 3 4
Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int index = -number;
while (index <= number)
{
    Console.Write(index + " ");
    index ++;
}
