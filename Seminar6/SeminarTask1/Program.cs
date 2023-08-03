// Задача 38
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()* new Random().Next(1,11),2);
    }
    return array;
}

//------------------Вывод массива в консоль---------------------

void PrintDoubleArrayToConsole(double[] array)
{
    string str = String.Join(' ', array); //перевод массива в строку
    Console.WriteLine($"Массив: {str}");
}

//-----------------------------------------------------------------

double[] array = GetRandomDoubleArray(10);
PrintDoubleArrayToConsole(array);

double max = Array.Max();
double min = Array.Min();

Console.WriteLine($"Разница между макс. {max} и мин. {min} элементами: {max-min}");