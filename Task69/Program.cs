// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 ->

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Power(int number, int degree)
{
    if (degree == 0) return 1;
    else return number * Power(number, degree - 1);
}
Console.WriteLine($"{num1},{num2} -> {Power(num1, num2)}");
