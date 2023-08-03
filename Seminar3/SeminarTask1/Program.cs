// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите любое целое число: ");
int usernumber = int.Parse(Console.ReadLine());


int tempAbsUserNumber = Math.Abs(usernumber); // создадим временную переменную в виде модуля числа

while (utempAbsUserNumber >= 1000) 
{
    tempAbsUserNumber =   tempAbsUserNumber / 10;
}

int thirdDigit = tempAbsUserNumber % 10;
Console.Write($"Третья цифра числа: {thirdDigit}");