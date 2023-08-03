// Задача 60. 
//Сформируйте трехмерный массив из неповторяющихся двухзначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[4, 4, 4]; //создание трехмерного массива

Dictionary<int, string> dict = new Dictionary<int, string>(); //создали словарь с ключом int и зачениемs tring

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int tempValue = new Random().Next(10,100);
            while(dict.ContainsKey(tempValue)) // пока словарь содержит такой ключ 
            {
              tempValue = new Random().Next(10,100);
              
            }
            array[i,j,k] = tempValue;  //то в массив помещаем значение
            dict.Add(tempValue, ""); // и помещаем в словарь значение
            
        }
    }
}


//Код для вывода массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
          Console.WriteLine($"Элемент под номером [{i} {j} {k}] = {array[i,j,k]}"); 

        }
    }
}