// Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//-----Заполнение массива случайными числами-----------------------

void NewArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

//-------Количество четных чисел в массиве-------------------------------

int EvenNumber (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {count++;}
    }
    return count;
}

//------------------------------------------------------------------------

int[] array = new int[4];
NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве: {EvenNumber(array)}");