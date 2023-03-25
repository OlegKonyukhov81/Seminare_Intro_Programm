// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNumInInterval(int firstNum, int secondNum)
{
    if (firstNum == secondNum + 1) return 0;
    else return firstNum + SumNumInInterval(firstNum + 1, secondNum);
}

if (num1 > num2)
{
    int currentNum = num1;
    num1 = num2;
    num2 = currentNum;
    int sumInterval = SumNumInInterval(num1, num2);
    Console.WriteLine($"M = {num1}; N = {num2} -> {sumInterval}");
}
else
{
    int sumInterval = SumNumInInterval(num1, num2);
    Console.WriteLine($"M = {num1}; N = {num2} -> {sumInterval}");
}

