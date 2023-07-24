// Задача 41
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//------------Ввод пользвателем часел массива---------------
int[] NewArrayUser(int N, int[] array)
{
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

//-----------Счетчик для положительных чисел------------------

int PosCountArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

//--------------------------------------------------------------

Console.WriteLine("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];
NewArrayUser(M, array);
Console.WriteLine($"Количество положительных чисел в массиве: {PosCountArray(array)}");








