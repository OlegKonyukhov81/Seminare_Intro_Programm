// Программа, которая принимает на вход трехзначное число, 
// а на выходе показывает последнюю цифру этого числа
Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа {number} является {lastNumber}"); 
}
else Console.Write("Вы ввели не трехзначное число");
