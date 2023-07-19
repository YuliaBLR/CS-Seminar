// Задача 36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//-----Заполнение массива случайными числами-----------------------

void NewArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
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

//------Сумма элементов на нечетной позиции-------------------------

int OddNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
    {sum = sum + array[i];}
    return sum;
}

//------------------------------------------------------------------

int[] array = new int[5];
NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов на нечетныхтпозициях равна: {OddNumber(array)}");