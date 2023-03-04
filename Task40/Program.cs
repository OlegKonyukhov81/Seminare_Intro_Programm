// Программа, которая на вход принимает три числа и проверяет может ли существовать треугольник
// со сторонами такой длины.
// Задача решается при помощи теоремы о неравенстве треугольника, каждая сторона треугольника меньше 
// суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[]{num1, num2, num3}; 

bool ValidateOfTriangle(int side1, int side2, int side3)
{
    // if (side1 < side2 + side3)
    {
        // if (side2 < side1 + side3)
        // {
        //     if (side3 < side1 + side2)
        //     {
        //         return true;
        //     }
        //     else return false;
        // }
        // else return false;
    }
    else return false;
}

// void PrintRandomArray(int[] printArray)
// {
//     Console.Write("[");
//     for (int i = 0; i < printArray.Length; i ++)
//     {
//         Console.Write($"{printArray[i]}");
//         if (i < printArray.Length -1) Console.Write(", ");
//     }
//     Console.Write("]");
// }

// PrintRandomArray(array);
if (ValidateOfTriangle(num1, num2, num3))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
