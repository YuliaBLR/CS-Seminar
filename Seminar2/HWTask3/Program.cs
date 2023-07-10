// Задача 15
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
       Console.Write("Этот день выходной"); 
    }
    else
    {
        Console.Write("Этот день не выходной");
    }
}
else
{
    Console.Write("В неделе нет такого дня");
}