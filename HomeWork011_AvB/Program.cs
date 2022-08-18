int NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = NameNumber("Введите первое число: ");
int b = NameNumber("Введите второе число: ");

Console.Write("Ответ: " + a + " в степени " + b + " = " + Math.Pow(a, b));