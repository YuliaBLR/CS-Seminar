// Задача 10
// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number / 100 == 0 || number / 100 > 9)
{
  Console.Write("Число не трехзначное");  
}
else
{
    number = number / 10;
    number = number % 10;
    Console.Write($"Вторая цифра числа: {number}");
}