// Задача 37
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

//-----Заполнение массива рандомными числами-----------------------

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

//---------Произведение попарных чисел----------------------------

void NumberArrayUmn (int [] array)
{
int i = 0;
int Umn = 0;
if (array.Length % 2 == 0)
{ 
while (i < array.Length/2)
{    
Umn = array[i] * array[array.Length - (1+i)];
Console.Write($"{Umn} ");
i++;
}
}
else 
{  
    while (i < array.Length/2)
{    
Umn = array[i] * array[array.Length - (1+i)];
Console.Write($"{Umn} ");
i++;
}
Console.Write($"{array[array.Length/2]} ");
}
}

//----------------------------------------------------------------

int[] array = new int[7];
NewArray(array);
PrintArray(array);
Console.WriteLine();
NumberArrayUmn(array);
