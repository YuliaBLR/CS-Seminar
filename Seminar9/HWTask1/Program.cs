// Задача 1. 
//Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

//-----Максимальное кколичество следующих друг за другом 1
int GetMaxCount1Array(int[] array)
{
    int resalt = 0;
    int maxresalt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            resalt++;
        }
        else
        {
            resalt = 0;
        }
        if (resalt > maxresalt && resalt != 1)
        {
            maxresalt = resalt;
        }
    }
    return maxresalt;
}

//-------------------------------------------------------

int[] array = new int[] { 1, 0, 1, 0, 0, 0, 1 };
Console.WriteLine(GetMaxCount1Array(array));

