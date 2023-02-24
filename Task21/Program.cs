// Программа, которая принимает на вход координаты 2-х точек 
// и выдает расстояние между ними в 3D пространстве
// a(3,6,8) b(2,1,-7) - 15,84 ; a(7, -5, 0) b(1,-1,9) - 11,53

Console.WriteLine("Введите координаты двух точек");
Console.Write("Координата X первой точки: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y первой точки: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z первой точки: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата X второй точки: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y второй точки: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z второй точки: ");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance1 = ((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2)+((z1-z2)*(z1-z2)));
    double distance = Math.Sqrt(distance1);
    double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
    return distanceRound;
}

double result = Distance3D(numX1, numY1, numZ1, numX2, numY2, numZ2);
Console.WriteLine(result);
