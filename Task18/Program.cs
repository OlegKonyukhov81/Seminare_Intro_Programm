// Программа, которая по заданному номеру четверти выдает возможный диапазон координат в этой четверти.

// Console.Write("Введите номер четверти от 1 до 4: ");
// int numberQuarter = Convert.ToInt32(Console.ReadLine());

// bool ValidateQuarter(int quarter)
// {
//     return quarter > 0 && quarter < 5;
// }

// void SearchCoordinates(int quarter)
// {
//     if (quarter == 1) Console.WriteLine("x > 0; y > 0");
//     if (quarter == 2) Console.WriteLine("x < 0; y > 0");
//     if (quarter == 3) Console.WriteLine("x < 0; y < 0");
//     if (quarter == 4) Console.WriteLine("x > 0; y < 0");
// }

// if (ValidateQuarter(numberQuarter))
// SearchCoordinates(numberQuarter);
// else Console.WriteLine("Введите корректный номер четверти!");

// или с Prompt

// int Prompt(string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// string SearchCoordinates(int quarter)
// {
//      if (quarter == 1) return "x > 0; y > 0";
//      if (quarter == 2) return "x < 0; y > 0";
//      if (quarter == 3) return "x < 0; y < 0";
//      if (quarter == 4) return "x > 0; y < 0";
//      return "Введите корректный номер четверти!"; 
// }
// int digitQuarter = Prompt("Введите номер четверти от 1 до 4: ");
// string numberQuarter = SearchCoordinates(digitQuarter);
// Console.WriteLine($"{numberQuarter}");

// или сравниваем строки

Console.Write("Введите номер четверти от 1 до 4: ");
string numberQuarter = Console.ReadLine();

string SearchCoordinates(string quarter)
{
    if (quarter == "1") return "x > 0; y > 0";
    if (quarter == "2") return "x < 0; y > 0";
    if (quarter == "3") return "x < 0; y < 0";
    if (quarter == "4") return "x > 0; y < 0";
    return "Введите корректный номер четверти!"; 
}
Console.WriteLine(SearchCoordinates(numberQuarter));