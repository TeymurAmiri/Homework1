// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a = NameNumber("");
int SecondFigure = SecondNumber(a);

if(a > 99 && a < 1000 || a < -99 && a > -1000)
{
    int number2 = SecondNumber(a);
    Console.WriteLine("Вторая цифра числа " + a + " = " + number2);
}
else
{
    Console.Write("Ошибка. Введите ТРЕХзначное число ");
}

int NameNumber(string message)
{
    Console.Write ("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int SecondNumber(int b) // Метод выяявления второго числа.
{
    int first = b % 100;
    int second = b % 10;
    int result = (first - second) / 10;
    return result;
}