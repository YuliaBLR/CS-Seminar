// Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


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

//-----Нахождение элемента по координатам

int FindNumArray(int[,] array, int row, int column)
{
    int a = 0;
            for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == row && j == column)
            {
                a = array[i, j];
            }
        }
    }
    return a;
}


//--------------------------------------------------------

Console.Write("Введите количество строк: ");
int arrayrow = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arraycolumn = int.Parse(Console.ReadLine());
int[,] array = new int[arrayrow, arraycolumn];
RandomNumArray(array);
PrintArray(array);
Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());
if (FindNumArray(array, row, column) != 0)
{
    Console.Write($"Искомый элемент массива: {FindNumArray(array, row, column)}");
}
else 
{
    Console.Write("Такого элемента в массиве нет");
}
