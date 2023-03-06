// Программа, которая находит точку пересечения двух прямых,
// заданных уравнениями y=k1*x + b1; y=k2*x + b2; Значения b1, k1, b2, k2 задаются пользователем.
//b1=2 k1=5 b2=4 k2=9 -> (-0,5; -0,5)

Console.Write("Введите b1; ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1; ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2; ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2; ");
int k2 = Convert.ToInt32(Console.ReadLine());


bool ValidateK1andK2(int ratio1, int ratio2)
{
    if (ratio1 != ratio2) return true;
    else return false;
}

double[] IntersectionPoint(int ratioB1, int ratioK1, int ratioB2, int ratioK2)
{
    double[] point = new double[2];
    // double x = 0;
    // double y = 0;
        double y1 = (ratioB1-(ratioK1 * ratioB2 / ratioK2))/(1 - ratioK1 / ratioK2);
        point[1] = Math.Round(y1, 1, MidpointRounding.ToZero);
        double x1 = (point[1] - ratioB2) / ratioK2;
        point[0] = Math.Round(x1, 1, MidpointRounding.ToZero);
        // point[0] = x;
        // point[1] = y;
    return point;
}

void PrintRandomArray(double[] printArray)
{
    Console.Write("(");
    for (int i = 0; i < printArray.Length; i ++)
    {   
        Console.Write($"{printArray[i]} ");
        if (i < printArray.Length - 1)
        Console.Write("; ");
    }
    Console.Write(")");
}
Console.Write($"b1 = {b1} k1 = {k1} b2 = {b2} k2 = {k2} -> ");
if (ValidateK1andK2(k1, k2))
{
    double[] intersectionPoint = IntersectionPoint(b1, k1, b2, k2);
    PrintRandomArray(intersectionPoint);
}
else 
Console.WriteLine("Прямые не пересекутся т.к k1 = k2!");