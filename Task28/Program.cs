// Программа, которая принимает на вход число А, и выдает произведение чисел от 1 до А.

Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

bool ValidateZeroNum(int value)
{
    if (value > 0) return true;
    else return false;
}
int MultiplicatioNumbers(int lastNumber)
{
        int multiplicNum = 1;
        for (int i = 1; i <= lastNumber; i ++)
        {
            multiplicNum = multiplicNum * i;
        }
        return multiplicNum;
}
if (ValidateZeroNum(number))
{
    int result = MultiplicatioNumbers(number);
    Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine("Введеное число не больше нуля!");