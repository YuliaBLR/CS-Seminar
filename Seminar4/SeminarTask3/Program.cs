// Задача 26. 
//Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.

void Getquantity (int number)
{
    number = Math.Abs (number);
    string N = number.ToString();
    Console.Write($"Количество цифр в числе: {N.Length}");
}

//--------------------------------------------------------

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Getquantity(number);