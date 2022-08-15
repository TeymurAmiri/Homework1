int x1 = NameInt("Введите координату X точки A: ");
int y1 = NameInt("Введите координату Y точки A: ");
int c1 = NameInt("Введите координату C точки A: ");
int x2 = NameInt("Введите координату X точки B: ");
int y2 = NameInt("Введите координату Y точки B: ");
int c2 = NameInt("Введите координату C точки B: ");

int LengthX = Length(x1, x2); 
int LengthY = Length(y1, y2);
int LengthC = Length(c1, c2);

double result = Sqr(LengthX, LengthY, LengthC);

Console.Write("Расстояние между точками A и В = " + result);

int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Length(int a, int b)
{
    return b - a;
}

double Sqr(int a, int b, int c)
{
    double Sqr1 = Convert.ToDouble(a*a + b*b + c*c);
    return Math.Sqrt(Sqr1);
}