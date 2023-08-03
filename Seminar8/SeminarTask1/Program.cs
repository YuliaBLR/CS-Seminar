// Есть двумерный массив. Нужно определить столбец с наименьшей суммой чисел.

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

//-----Определение столбца с наименьшей суммой чисел-----
int GetinSumColumnFromArray(int[,] array)
{
    int resaltColumn = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tempsum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            tempsum = tempsum + array [j,i];
        }
        if (tempsum < min)
        {
            min = tempsum;
            resaltColumn = i;
        }
    }

    return resaltColumn;
}

//--------------------------------------------

int[,] array = GetDoubleArray(3, 4);
PrintDoubleArray(array);
Console.WriteLine($"Номер столбца с наименьшей суммой: {GetinSumColumnFromArray(array)}");

