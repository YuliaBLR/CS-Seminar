// Задача 28
//Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.

int GetFactorial(int number)
{
    int multiplication = 1;
    for (int i = 1; i <= number; i++)
    {
        multiplication = multiplication * i;
    }
    return multiplication;
}

//--------------------------------------------------------

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"Факториал числа: {GetFactorial(N)}");
