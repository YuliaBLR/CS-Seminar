// Задача 2:
//Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

//-----Число из элементов массива слева-направо +1
int GetToNumberArray(int[] array)
{
    int tempnumber = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        tempnumber = tempnumber * 10 + array[i];
    }
    int resaltnumber = tempnumber * 10 + (array[array.Length - 1] + 1);
    return resaltnumber;

}

//---------------------------------------------------------------

int[] array = new int[] { 1, 2, 1, 1, 4 };
Console.WriteLine(GetToNumberArray(array));
