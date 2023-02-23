// Программа, которая по заданному номеру четверти выдает возможный диапазон координат в этой четверти.

Console.Write("Введите номер четверти от 1 до 4: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

bool ValidateQuarter(int quarter)
{
    return quarter > 0 && quarter < 5;
}

void SearchCoordinates(int quarter)
{
    if (quarter == 1) Console.WriteLine("x > 0; y > 0");
    if (quarter == 2) Console.WriteLine("x < 0; y > 0");
    if (quarter == 3) Console.WriteLine("x < 0; y < 0");
    if (quarter == 4) Console.WriteLine("x > 0; y < 0");
}

if (ValidateQuarter(numberQuarter))
SearchCoordinates(numberQuarter);
else Console.WriteLine("Введите корректный номер четверти!");
