// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunc(int m, int n)
{
    if (m == 1 && n == 0 || m == 0 && n == 1) n = 2;
    if (n == 0 || m > 0) AckermannFunc(m - 1, n + 1);
    if (n > 0 || m > 0) AckermannFunc(m - n, AckermannFunc(m, n - 1));
    
}

int ackermann = AckermannFunc(1, 0);
Console.WriteLine(ackermann);
//AckermannFunc(1, 1);