// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int a = ReadInt("Введите число: ");
if (a > 0)
{
    Cube1(a);
}
else if (a < 0)
{
    Cube2(a);
}
else if (a == 0)
{
    Console.Write("Последовательность кубов отсутствует. Ноль в кубе равен нулю. ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int a)
{
    return a*a*a;
}

void Cube1(int a)
{
   int number = 1;
   Console.Write("Последовательность кубов: ");
   while(number <= a)
   {
        Console.Write(Cube(number) + " ");
        number++;
   }
}

void Cube2(int a)
{
   int number = -1;
   Console.Write("Последовательность кубов: ");
   while(number >= a)
   {
        Console.Write(Cube(number) + " ");
        number--;
   }
}