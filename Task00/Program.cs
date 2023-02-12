// Программа, которая на вход принимает число, а выдает его квадрат.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");