// Программа, которая принимает номер дня недели и проверяет является ли этот день выходным.

Console.Write("Введите номер дня недели - ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void SearchWeekend(int day)
{
    if (day >= 1 && day <= 7)
    {
        if (day == 6 || day == 7)
        {
            Console.WriteLine($"{day} -> Да");
        }
        else Console.WriteLine($"{day} -> Нет");
    }
    else Console.WriteLine("Введите корректный день недели");
}

SearchWeekend(dayNumber);
