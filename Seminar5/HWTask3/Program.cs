// Задача 38
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//-----Заполнение массива случайными вещественными числами-----------------------

void NewArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10) + new Random().NextDouble();
    }
}

//------Печать массива--------------------------------------------------

void PrintArray (double [] array)
{
        for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} "); // округление до 2 знака после запятой
    }                                                 //(значения посередине округляются до ближайшего четного числа)
}

//---Разница между максимальным и минимальным элементами массива--------------

double DifferenceMaxMinNumbers (double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {min = array[i];}
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {max = array[i];}
    }
    dif = max - min;
    return Math.Round(dif, 2);
}

//------------------------------------------------------

double[] array = new double[4];
NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементами массива: {DifferenceMaxMinNumbers(array)}");