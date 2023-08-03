// Задача 49
//Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

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

//-----Замена элементов--------------------------------

int[,] PowNumArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

//-------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
int[,] array = new int[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);
PowNumArray(array);
Console.WriteLine();
PrintArray(array);
