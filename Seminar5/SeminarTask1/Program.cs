// Задача 31
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] array = new int[12];//создание массива

for (int i = 0; i < array.Length; i++) //заполнение массива
{
    array[i] = new Random().Next(-9,10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

//--------------------------------
//Подсчет отрицательных и положитлеьных элементов массива
int sumPosotive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPosotive += array[i];
    }
    if (array[i] < 0)
    {
        sumNegative += array[i];
    }
}

Console.Write($"Сумма положительных числе: {sumPosotive}." +
                $"\nСумма отрицательных чисел: {sumNegative}");