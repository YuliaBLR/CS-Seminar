// Задача 55
//Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//-----Генерация массива, заполненного случайными числами-----
int[,] GetDoubleArray(int counyRow, int counyCol)
{
    int[,] array = new int[counyRow, counyCol];
    for (int i = 0; i < counyRow; i++)
    {
        for (int j = 0; j < counyCol; j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
    return array;
}

//-----Печать массва-----

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

//-----Замена местами строк и столбцов-----

int[,] GetArray (int[,] array)
{
    int[,] temparray = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temparray[j, i] = array[i,j];
        }
    }
    return temparray;
}

//------------------------------------------------------

int[,] array = GetDoubleArray(2, 4);
PrintDoubleArray(array);
if(array.GetLength(0) == array.GetLength(1))
{
    int[,] resaltarray = GetArray(array);
    Console.WriteLine();
    PrintDoubleArray(resaltarray);
}
    else
    {
        Console.WriteLine("Заменить строки на столбцы невозможно, т.к. массив не квадратный");
    }


