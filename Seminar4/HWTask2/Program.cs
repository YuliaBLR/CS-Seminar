// Задача 27.
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int Sum (int number)
{
    int numbertemp = Math.Abs (number);
    int resalt = 0;
    while (numbertemp > 0)
    {
        int forsum = numbertemp % 10; // выуживам одну цифру из числа
        numbertemp = numbertemp / 10; // убираем выуженную цифру из числа
        resalt = resalt + forsum;
    }
    return resalt;

}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {Sum(number)} ");
