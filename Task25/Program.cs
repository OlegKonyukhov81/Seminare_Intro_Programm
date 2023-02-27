// Программа, которая на вход принимает числа А и В и возводит число А в натуральную степень В.

Console.WriteLine("Введите два числа, второе должно быть натуральным т.е > 0");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool ValidateNaturalNum(int verifiableNum)
{
    if (verifiableNum > 0) return true;
    else
    {
        Console.WriteLine("Второе число меньше нуля!");
        return false;
    }
}

int ExponentiationCycle(int number, int multiplier)
{
    int currentMultiplier = Math.Abs(number);
    // int count = 1;
    // while(count < multiplier)
    for (int i = 1; i < multiplier; i++)
    {
        currentMultiplier = currentMultiplier * number;
        // count ++;
    }
    return currentMultiplier;
}

if(ValidateNaturalNum(number2))
{
    int value = ExponentiationCycle(number1, number2);
    Console.WriteLine($"{number1}, {number2} -> {value}");
}
// else Console.WriteLine("Второе число меньше нуля");