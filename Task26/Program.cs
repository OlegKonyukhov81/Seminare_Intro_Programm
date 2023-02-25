// Программа, которая на вход принимает число, а выдает количество цифр в этом числе.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool ValidateZero(int value)
{
    if (value != 0) return true;
    else return false;
}

int CountDigits(int exploreNumber)
{
    int countDigits = 0;
    int cutNumber = 10;
    int currentNumber = exploreNumber;
    while (currentNumber > 0 || currentNumber % 10 > 0)
    {
        countDigits += 1;
        currentNumber = currentNumber / 10;
        cutNumber = cutNumber * 10;
    }
    return countDigits;
}

if (ValidateZero(number))
{
    int count = CountDigits(number);
    Console.WriteLine($"{number} -> {count}");
}
else Console.WriteLine($"{number} -> 1");
