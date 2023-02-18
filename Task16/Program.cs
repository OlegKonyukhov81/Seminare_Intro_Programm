// Программа, которая принимает на вход два числа и проверяет является ли одно число квадратом другого.

Console.WriteLine("Введите первое число -");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число - ");
int number2 = Convert.ToInt32(Console.ReadLine());

// bool CheckSquareNumbers(int firstNumber, int secondNumber)
// {
//     return firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber;
// }

// if (CheckSquareNumbers(number1, number2)) Console.WriteLine($"{number1}, {number2} -> ДА");
// else Console.WriteLine($"{number1}, {number2} -> НЕТ");

void CheckSquareNumbers(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    Console.WriteLine($"{num1}, {num2} -> ДА");
    else
    Console.WriteLine($"{num1}, {num1} -> НЕТ");
}
 CheckSquareNumbers(number1, number2);
