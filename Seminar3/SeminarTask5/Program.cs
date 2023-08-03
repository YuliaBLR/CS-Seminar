// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

double GetDistans(int x1, int y1, int x2, int y2)
{
    double distans = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distans;
}
//------------------------------------------

Console.Write("Введите координату х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write($"Расстояние между точками: {GetDistans(x1, y1, x2, y2)}");