﻿// Задача 40
// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//(Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше суммы двух других сторон)

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) 
     Console.WriteLine("Такой треугольник может существовать");
    else Console.Write("Такой треугольник не может существовать");
}
//-----------------------------------------------------------------

Console.WriteLine("Введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
Triangle(a, b, c);