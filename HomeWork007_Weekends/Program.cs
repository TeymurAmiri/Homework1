// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a = NameNumber("");

if(a >= 1 && a <= 7)
{
    if(a == 6 || a == 7)
    {
        Console.Write("Да.");
    }
    else
    {
        Console.Write("Нет.");
    }
}
else
{
    Console.Write("В неделе 7 дней. Введите число заново.");
}

int NameNumber(string message)
{
    Console.Write ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}