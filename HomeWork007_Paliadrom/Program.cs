

int Number = NameNumber("Введите число: ");
int NewNumber = 0;

if (Number == Pal(Number, NewNumber))
{
    Console.Write("Число является палиндромом");
}
else 
{
    Console.Write("Число не является палиндромом");
}

int NameNumber(string message)
{
    Console.Write(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Pal(int a, int c)
{
    c = 0;
    while(a > 0)
    {
        int d = a % 10;
        c = c * 10 + d;
        a = a / 10;    
    }
    return c;
}
