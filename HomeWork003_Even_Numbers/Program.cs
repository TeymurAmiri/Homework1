﻿Console.WriteLine("Условие задачи: ");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.Write("Задайте число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write("Число " + a + " является четным!");
}
else
{
    Console.Write("Число " + a + " не является четным!");
}