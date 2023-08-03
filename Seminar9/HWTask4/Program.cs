// Задача 4:
//Даны два положительных целых числа, представленных в виде строк. 
//Необходимо получить сумму чисел, которые представлены этими строками. 
//Причем полученная сумма должна быть преобразована в строку.
//Для решения этой задачи запрещено преобразовывать входные строки сразу 
//напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.


//---Преобразование строки в массив---------------------
int[] GetStringToArray(string s)
{
    int[] array = new int[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '0') array[i] = 0;
        if (s[i] == '1') array[i] = 1;
        if (s[i] == '2') array[i] = 2;
        if (s[i] == '3') array[i] = 3;
        if (s[i] == '4') array[i] = 4;
        if (s[i] == '5') array[i] = 5;
        if (s[i] == '6') array[i] = 6;
        if (s[i] == '7') array[i] = 7;
        if (s[i] == '8') array[i] = 8;
        if (s[i] == '9') array[i] = 9;
    }
    return array;
}

//-----Преобразование массива в число---------------
int GetArrayToNumber(int[] array)
{
    int tempnumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        tempnumber = tempnumber*10 + array[i];
    }
   return tempnumber;
}

//-----Нахождение суммы двух положительных чисел в виде строк-----------
void GetSum2String (string number1, string number2)
{
    int[] array1 = GetStringToArray(number1);
    int[] array2 = GetStringToArray(number2);
    int num1 = GetArrayToNumber(array1);
    int num2 = GetArrayToNumber(array2);
    string sum = Convert.ToString(num1+num2);
    Console.WriteLine($"Сумма двух чисел в ввиде строк равна: {sum}");
}

//------------------------------------------------------------

string number1 = "11";
string number2 = "123";
GetSum2String (number1, number2);