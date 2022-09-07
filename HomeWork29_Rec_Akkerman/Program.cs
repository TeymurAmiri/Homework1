// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = ReadInt($"Введите первое неотрицательное число: ");
int n = ReadInt($"Введите второе неотрицательное число: ");
Console.Write($"Вычисление функции Аккермана от {m} и {n} -> {AcermanFunction(m,n)}");

int AcermanFunction(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n ==0) return AcermanFunction(m-1, 1);
    else if(m > 0 && n > 0) return AcermanFunction(m - 1, AcermanFunction(m, n-1));
    return AcermanFunction(m,n);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}