// Программа, которая проверяет является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;
if (numberA == square)
{
    Console.WriteLine($"Число {numberA} является квадратом {numberB}");
}
else
{
Console.WriteLine($"Число {numberA} не является квадратом {numberB}");
}