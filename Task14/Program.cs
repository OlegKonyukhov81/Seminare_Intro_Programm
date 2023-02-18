// Программа, которая принимает число и проверяет кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());

void CheckMultiplicity7And23(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"{number} -> Да");
    else Console.WriteLine($"{number} -> Нет");
}

CheckMultiplicity7And23(num);
