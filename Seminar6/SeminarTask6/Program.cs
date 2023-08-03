// Задача 45
//Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.

//------------Создание копии-------------------------
void CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
}

//----Печать массива--------------------

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(", ", array));
}

//--------------------------------------------

int[] A = new int[]{1,5,7,3,4};
PrintArray(A);
CopyArray(A);
PrintArray(A);