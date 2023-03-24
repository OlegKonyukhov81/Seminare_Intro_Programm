// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2)
// {
//     NaturalNumFirstSecond(num1, num2);
// }
// else NaturalNumSecondFirst(num1, num2);

// void NaturalNumFirstSecond(int firstNum, int secondNum)
// {
//     // if (firstNum - 1 < secondNum)
//     {
//         if (secondNum == firstNum - 1) return; // Если есть строка 19 (строка выше),
//                                             // то до этого условия очередь не дойдет.
//         NaturalNumFirstSecond(firstNum, secondNum - 1);
//         Console.Write($"{secondNum} ");
//     }
// }

// void NaturalNumSecondFirst(int firstNum, int secondNum)
// {
//     if (secondNum == firstNum + 1) return;
//     NaturalNumSecondFirst(firstNum, secondNum + 1);
//     Console.Write($"{secondNum} ");
// }

// ИЛИ метод где учтены все условия, когда М>N, M<N, M=N

void PrintNumber(int firstNum, int secondNum)
{
    if (firstNum > secondNum)
    {
        Console.Write($"{firstNum} ");
        PrintNumber(firstNum - 1, secondNum);
    //     // или
    //     PrintNumber(firstNum, secondNum + 1);
    //     Console.Write($"{secondNum} ");
    }
    else if (firstNum < secondNum)
    {
        // Console.Write($"{firstNum} ");
        // PrintNumber(firstNum + 1, secondNum);
        // // или
        PrintNumber(firstNum, secondNum - 1);
        Console.Write($"{secondNum} ");
    }
    else
    {
        Console.Write($"{firstNum} "); // сюда падают значения, которые равны(а они всегда, 
                                // когда-нибудь будут равны),поэтому неважно, что выводить в консоль.
    }
}

PrintNumber(num1, num2);