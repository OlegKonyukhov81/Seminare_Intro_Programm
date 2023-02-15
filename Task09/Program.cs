// 
int number = new Random().Next(10, 100);
Console.WriteLine($"Число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) 
Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else
Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {MaxDigit}");

int MaxDigit(int num)
{
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit) return firstDigit; 
else return secondDigit;
}

int number = new Random().Next(100, 999);
Console.WriteLine($"Число из отрезка {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int twoDigitnum = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Число без второй цифры -> {twoDigitnum}");

