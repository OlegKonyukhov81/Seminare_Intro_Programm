// Программа, которая выводит случайное трехзначное число, затем удаляет вторую цифру этого числа.

int thirdNum = new Random().Next(100, 999);
Console.WriteLine($"Случайное трехзначное число - {thirdNum}");

int DeleteSecondDigit(int num)
{
    int num1 = num / 100;
    int num2 = num % 10;
    return num1 * 10 + num2;
}

int withOutTwoNum = DeleteSecondDigit(thirdNum);
Console.WriteLine($"Число без второй цифры - {withOutTwoNum}");
