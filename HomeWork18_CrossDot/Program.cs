double k1 = NameNumber("Число k1 = ");
double k2 = NameNumber("Число k2 = ");
double b1 = NameNumber("Число b1 = ");
double b2 = NameNumber("Число b2 = ");

CrossCord(k1, k2, b1, b2);

void CrossCord(double a, double b, double c, double d)
{
    double x = (d - c)/(a - b);
    double y1 = a * x + c;
    double y2 = b * x + d;

    Console.Write($"Точка пересечения: {y1} , {y2}");
}

double NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}