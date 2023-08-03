// Задача 42
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void BinNumber (int number)
{
    int numbertemp = number;
    string str = String.Empty;
    while (number > 0)
    {
        numbertemp = number % 2;
        number = number / 2;
        str = numbertemp + " " + str;
    }
    Console.WriteLine(str);
}

//----------------------------------------------

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
BinNumber(number);