// Программа, которая принимает 5-ти значное число и проверяет, является ли оно полиндромом

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool ValidateNumber(int fiveDiditNum)
// {
//     return fiveDiditNum >= 10000 && fiveDiditNum <= 99999;
// }

// void CheckPalindrome(int number)
// {
//     if (number / 10000 == number % 10)
//     {
//         if (number / 1000 % 10 == number / 10 % 10)
//         Console.WriteLine($"{number} -> Да");
//     }
//     else Console.WriteLine($"{number} -> Нет");
// }
// if (ValidateNumber(num)) 
// {
//     CheckPalindrome(num);
// }
// else Console.WriteLine("Вы ввели не пятизначное число!");

// или через bool

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int fiveDiditNum)
{
    return fiveDiditNum >= 10000 && fiveDiditNum <= 99999;
}
bool CheckPalindrome(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        return true;
    }
    else return false;
}

if (ValidateNumber(num))
{
    if (CheckPalindrome(num))
    {
        Console.WriteLine($"{num} -> Да");
    }
    else Console.WriteLine($"{num} -> Нет");
}
else Console.WriteLine("Вы ввели не пятизначное число!");