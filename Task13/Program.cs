// Программа, которая выводит третью цифру заданного числа или сообщает, что этой цифры нет.

Console.Write("Введите целое число - ");
int currentNumber = Convert.ToInt32(Console.ReadLine());

void PullThirdDigit(int number)
{
    if (number / 100 >= 1)
    {
        int thirdDigit = (number / 100) % 10;
        Console.WriteLine($"{number} -> {thirdDigit}");
    }
    else Console.WriteLine($"{number} -> теретьей цифры нет");
}
PullThirdDigit(currentNumber);
