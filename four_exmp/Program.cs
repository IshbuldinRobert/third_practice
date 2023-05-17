Console.WriteLine("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double Sum(double coord1, double coord2)
{
    double sum = coord1 - coord2;
    return sum;
}

double distance = Math.Sqrt((Math.Pow(Sum(x1, x2), 2)) + Math.Pow(Sum(y1, y2), 2));
Console.WriteLine($"Расстояние между двумя точками {Math.Round(distance, 3)}");