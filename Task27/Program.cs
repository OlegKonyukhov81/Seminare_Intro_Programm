// Программа, которая на вход принимает число, а на выходе дает сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitsOfNumber(int exploreNum)
{
    int currentNum = Math.Abs(exploreNum);
    int sumNumber = 0;
    while (currentNum > 0)
    {
        sumNumber = sumNumber + (currentNum % 10);
        currentNum = currentNum / 10;
    }
    return sumNumber;
}
int sumDigits = SumDigitsOfNumber(number);
Console.WriteLine(sumDigits);
