// Задача 43
//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Координаты точки пересечения: ({x},{y})");