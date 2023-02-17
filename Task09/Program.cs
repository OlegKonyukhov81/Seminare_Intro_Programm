// Программа, которая выводит случайное число от10до99 и показывает наибольшую цифру этого числа.

int number = new Random().Next(10, 100);
Console.WriteLine(number);
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// }
// else 
// Console.WriteLine($"Наибольшая цифра числа {secondDigit}");


int SearchMaxDigit(int num)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    // if (digit1 > digit2)
    // {
    //     return digit1;
    // }
    // return digit2;
    // вместо выше написанного условия можно использовать тэрнарный оператор см. ниже
    // int result = digit1 > digit2 ? digit1 : digit2; // 
    // return result;
    // или
    return digit1 > digit2 ? digit1 : digit2;
}

int maxDigit = SearchMaxDigit(number); // Мы можем вызвать результат работы метода в любом месте кода -
// - можно выше метода
Console.WriteLine(maxDigit); // Свернуть, чтобы не занимал много места

// int maxDigit = SearchMaxDigit(57); // <- Менять входящие данные
// Console.WriteLine(maxDigit);