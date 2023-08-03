// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = -numberA;
while (numberB <= numberA)
    {
        Console.Write($"{numberB} ");
        numberB++;
    }