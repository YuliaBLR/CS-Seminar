// Задача 57
//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

//-----Частотный словарь по цифрам-----

void FindNumArray (int[,] array)
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