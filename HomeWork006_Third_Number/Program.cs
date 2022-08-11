// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры

int a = NameNumber("");
int Length = NumberLength(a);
if(Length >= 3)
{
    int third1 = ThirdNumber(Length, a);   
    Console.Write("Третьей цифрой числа " + a + " является цифра " + third1);
}
else
{
    Console.Write("Третьей цифры нет. ");
}


int NameNumber(string message)
{
    Console.Write ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int NumberLength(int number)
{
    int count = 0;
    while(number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int ThirdNumber(int length, int number)
{
    while(length > 3)
    {
        number = number / 10;
        length--;
    }
    return number % 10;
}