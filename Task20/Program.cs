// Программа, которая принимает координаты двух точек, а выводит расстояние между ними в 2D прстранстве
// а(3, 6) в(2, 1)  - 5,09
// а(7, -5) в(1, -1) - 7,21
Console.WriteLine("Введите координаты двух точек");
Console.Write("Координата Х первой точки: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата У первой точки: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Х второй точки: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата У второй точки: ");
int numY2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(numX1, numY1, numX2, numY2);
Console.WriteLine(result);

double Distance(int x1, int y1, int x2, int y2)
{
    double distance1 = ((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2));
    double distance = Math.Sqrt(distance1);
    double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
    return distanceRound;
}

