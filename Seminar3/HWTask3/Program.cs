// Задача 23
// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void GetCube (int number)
{
    for (int i =1; i<=number; i++)
    Console.Write($"{i*i*i} ");
}

//---------------------------------------------------------

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
GetCube(number);
