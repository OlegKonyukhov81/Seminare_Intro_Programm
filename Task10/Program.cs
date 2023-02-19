// Программа, которая на вход принимает трехзначное число, а выдает вторую цифру этого числа.

Console.Write("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

void PullSecondDigit(int threeDigitNum)
{
    if (threeDigitNum < 0)
    {
        int moduleNumber = threeDigitNum * (-1);
        if (moduleNumber / 1000 <= 0 && moduleNumber / 100 >= 1)
        {
            int secondDigit1 = (moduleNumber % 100) / 10;
            Console.WriteLine($"{threeDigitNum} -> {secondDigit1}");
        }
        else Console.WriteLine($"Вы ввели не трехзначное число");
    }
    else if (threeDigitNum / 1000 <= 0 && threeDigitNum / 100 >= 1)
    {
        int secondDigit = (threeDigitNum % 100) / 10;
        Console.WriteLine($"{threeDigitNum} -> {secondDigit}");
    }
    else Console.WriteLine($"Вы ввели не трехзначное число");
}
PullSecondDigit(number);



