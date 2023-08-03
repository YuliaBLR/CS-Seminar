// Задача 33
//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

void NewArray (int [] array)
{
        for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,11);
    }
}

//--------------------------------------------------------

void PrintArray (int [] array)
{
        for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//--------------------------------------------------------

bool NumberTrue(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {return true; break;}      
    } 
    return false;  
    }
//----------------------------------------------------------


int[] array = new int[5];
NewArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
NumberTrue(number, array);
if (NumberTrue(number, array))
    Console.Write("Да");
else Console.Write("Нет");