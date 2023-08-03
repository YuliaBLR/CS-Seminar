// Задача 51
//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

//-----Сумма элементов на главной диагонали--------------------------------

int SumNumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum += array[i, j];
        }
    }
    return sum;
}

//-------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
int[,] array = new int[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали равна: {SumNumArray(array)}");