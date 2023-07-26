// Задача 52
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//-----Заполнение массива случайными числами--------------

int[,] RandomNumArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

//-----Печать массива-------------------------------------

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//-----Среднее арифметическое элементов каждого столбца---------

void MeanColumnArray(int[,] array)
{
    int number = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double mean = Math.Round(sum / array.GetLength(0),1);
        Console.WriteLine($"Среднее арифметическое столбца [{number}] равно {mean}");
        number++;
    }
}

//---------------------------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
int[,] array = new int[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);
MeanColumnArray(array);
