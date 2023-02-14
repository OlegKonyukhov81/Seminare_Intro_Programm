// Программа, которая на вход принимает число и выдает, является ли это число четным
// (делится ли оно на два без остатка)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = number % 2;
if (number != 0)
{
    if (evenNumber != 0) 
    Console.WriteLine($"Число {number} - нечетное");
    else 
    Console.WriteLine($"Число {number} - четное");
}
else 
Console.WriteLine($"Вы ввели нуль");
