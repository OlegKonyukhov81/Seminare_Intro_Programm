﻿// Программа, которая на вход принимает два числа, а выводит - является ли первое число кратным второму,
// Если 1 число не кратно 2-му, программа выводит остаток.

Console.Write("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

// void CheckMultipliDig(int firstNumber, int secondNumber)
// {
//     int remainder = firstNumber % secondNumber; // переменная remainder - остаток от деления num1 на num2
//     if (remainder == 0)
//     {
//         Console.WriteLine($"Число {firstNumber} кратно {secondNumber}");
//     }
//     else Console.WriteLine($"Остаток {remainder}");
// }

// CheckMultipliDig(num1, num2);

bool CheckMultipliDigits(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0)
    {
        return true;
    }
    return false;
}

int CheckReminder(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}

if (CheckMultipliDigits(num1, num2))
{
    Console.WriteLine($"{num1} кратно {num2}");
}
int reminder = CheckReminder(num1, num2);
Console.WriteLine(reminder);