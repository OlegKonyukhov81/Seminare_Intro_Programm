// Программа, которая на вход принимает координаты (х, у)
// причем х,у не равны 0, а выдает номер четверти.

Console.Write("Введите координату Х точки: ");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату У точки: ");
int coordinateY = Convert.ToInt32(Console.ReadLine());

int SearchQuarter(int absciss, int ordinate)
{
        if (absciss > 0 && ordinate > 0) return 1;
        if (absciss > 0 && ordinate < 0) return 4;
        if (absciss < 0 && ordinate > 0) return 2;
        if (absciss < 0 && ordinate < 0) return 3;
        else return 0;
}
// int quarter = SearchQuarter(coordinateX, coordinateY);
// if (quarter == 0) Console.WriteLine("Вы ввели ноль!");
// else Console.WriteLine($"{quarter}");

// или

int quarter = SearchQuarter(coordinateX, coordinateY);
string result = quarter > 0 ? $"{quarter}" : "Вы ввели ноль!";
Console.WriteLine(result);
