// Задача 22
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

void GetPow (int number)
{
for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i} ");
}
}

//---------------------------------------------------------

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
GetPow(number);