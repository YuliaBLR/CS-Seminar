// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number>99 && number<1000)
    {
    int resalt = number%10;
    Console.WriteLine($"Последняя цифра вашего числа: {resalt}");
    }
else 
    {
    Console.WriteLine("Ваше число не соответствует условию: трехзначное число (от 100 до 999)");
    }

Console.WriteLine("Конец программы");