// Программа, которая на вход принимает три числа, а выдает максимальное из этих чисел
// 
Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    if (numberC > numberA) 
    {
    Console.Write($"Максимум -> {numberC}");
    }
    else
    Console.Write($"Максимум -> {numberA}");
}
else
{
    if (numberC > numberB)
    Console.Write($"Max -> {numberC}");
    else
    Console.Write($"Max -> {numberB}");
}