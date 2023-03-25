// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigitsNumber(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumDigitsNumber(number / 10);
    Console.WriteLine($"{number}");
}

int sumDigits = SumDigitsNumber(num);
Console.WriteLine(sumDigits);
