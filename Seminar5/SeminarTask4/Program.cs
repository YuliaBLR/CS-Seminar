// Задача 35
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//-----Заполнение массива рандомными числами-----------------------

void NewArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
}

//------Печать массива--------------------------------------------------

void PrintArray (int [] array)
{
        for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//----Нахождение элементов в отрезке и их подсчет----------------------------

int SeeFor (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if (array[i] >= 10 && array[i] <= 99)
    {count++;}
    return count;
}

//--------------------------------------------------------------------------

int[] array = new int[123];
NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество числе в диапазоне [10;99]: {SeeFor(array)}");