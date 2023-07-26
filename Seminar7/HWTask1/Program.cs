// Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//-----Заполнение массива случайными числами--------------

double[,] RandomNumArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
    }
    return array;
}

//-----Печать массива-------------------------------------

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//-------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
double[,] array = new double[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);
