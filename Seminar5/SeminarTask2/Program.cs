// Задача 32
//Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

void Array (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
         array[i] = Math.Abs (array[i])*(-1);
         Console.Write($"{array[i]} ");
        }

        else
        {
        array[i] = Math.Abs (array[i]);
        Console.Write($"{array[i]} ");
        }
    }
}

int[] array = {-4,-8,8,2};
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();
Array(array);


