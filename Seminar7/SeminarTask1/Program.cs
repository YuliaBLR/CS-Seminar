// Задача 46
//Задайте двумерный массив размером mxn, заполненный случайными числами.

Console.Write("Введите кооличество строк: ");
int countRow = int.Parse(Console.ReadLine());
Console.Write("Введите кооличество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int[countRow, countColumn];

//---------Заполнение цикла случайными числами---------------
for (int i = 0; i < countRow; i++) //перемещение по строкм
{
    for (int j = 0; j < countColumn; j++) // перемещение по столбцам
        array[i, j] = new Random().Next(0, 11);
}

//-------Печать массива----------------------------

for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

//-----------Вывод суммы элементов каждой строки-----------

for (int i = 0; i < countRow; i++)
{
    int sum = 0;
    for (int j = 0; j < countColumn; j++)
        sum = sum + array[i, j];
        Console.WriteLine($"В строке {i+1} сумма элементов равна {sum}");
}

