// Программа, которая выводит третью цифру заданного числа или сообщает, что этой цифры нет.

Console.Write("Введите целое число : ");
int currentNumber = Convert.ToInt32(Console.ReadLine());

void PullThirdDigit(int number)
{
    if (number < 0)
    {
        int moduleNumber = number * (-1);
        if (moduleNumber / 100 >= 1)
        {
            int thirdDigit1 = (moduleNumber / 100) % 10;
            Console.WriteLine($"{number} -> {thirdDigit1}");
        }
        else Console.WriteLine($"{number} -> третьей цифры нет");
    }

    else if (number / 100 >= 1)
    {
        int thirdDigit = (number / 100) % 10;
        Console.WriteLine($"{number} -> {thirdDigit}");
    }
    else Console.WriteLine($"{number} -> теретьей цифры нет");
}
PullThirdDigit(currentNumber);
