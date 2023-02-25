// Программа, которая на вход принимает число А, а выдает сумму чисел от 1 до А.

// int Prompt(int message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// bool ValidatePositiveNum(int value)
// {
//     if (value >= 0 && value % 1 == 0) return true;
//     else return false;
// }

// ИЛИ

int SumNumbers(int lastNumber)
{
    if (lastNumber >= 0 && lastNumber % 1 == 0)
    {
        int currentNum = 0;
        int sumNumber = 0;
        while (currentNum <= lastNumber)
        {
            sumNumber = sumNumber + currentNum;
            currentNum +=1;
        }
        return sumNumber;
    }
    else return -1;
}
int sumNum = SumNumbers(number);
if (sumNum > 0)
{
    Console.WriteLine($"{number} -> {sumNum}");
}
else Console.WriteLine("Вы ввели отрицательное число!");

// ИЛИ

// void SumNumbers(int lastNumber)
// {
//     int currentNum = 0;
//     int sumNumber = 0;
//     while (currentNum <= lastNumber)
//     {
//         sumNumber = sumNumber + currentNum;
//         currentNum +=1;
//     }
//     Console.WriteLine($"{lastNumber} -> {sumNumber}");
// }

// if (ValidatePositiveNum(number))
// {
//     SumNumbers(number);
// }
// else Console.WriteLine("Вы ввели отрицательное число!");
