// Программа, которая на вход принимает трехзначное число, а выдает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число -");
int number = Convert.ToInt32(Console.ReadLine());

void PullSecondDigit(int threeDigitNum)
{
    if (threeDigitNum / 1000 == 0 && threeDigitNum / 100 >= 1)
    {
        int secondDigit = (threeDigitNum % 100) / 10;
        Console.WriteLine($"{threeDigitNum} -> {secondDigit}");
    }
    else Console.WriteLine($"Вы ввели не трехзначное число");
}
PullSecondDigit(number);



