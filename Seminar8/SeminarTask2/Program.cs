// Задача 53
//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

//-----Изменение местами первой и последней строки-----

int[,] GetArray (int [,] array)
{
       int[,] temparray = new int[array.GetLength(0), array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
    {
        temparray[temparray.GetLength(0)-1,j] = array[0,j];
        temparray[0,j] = array[array.GetLength(0)-1,j];
    }
    for (int i = 1; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temparray[i,j] = array[i,j];
        }
    }

        return temparray;
}

//-------------------------------------------------

int[,] array = GetDoubleArray(4, 4);
PrintDoubleArray(array);
GetArray(array);
Console.WriteLine();
int[,] resaltarray = GetArray(array);
PrintDoubleArray(resaltarray);
