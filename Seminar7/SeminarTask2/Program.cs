// Задача 48.
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.

//-----Заполнение массива случайными числами--------------

int[,] RandomNumArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = i + j;
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

//-------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
int[,] array = new int[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);





