

int NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int a)
{
    int sum = 0;
    while(a > 0 || a < 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}


int number = NameNumber("Введите число: ");
int a = Sum(number);
Console.Write("Сумма всех цифр числа " + number + " = " + a);