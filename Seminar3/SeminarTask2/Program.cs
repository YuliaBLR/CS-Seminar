// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите любое целое число: ");
int usernumber = int.Parse(Console.ReadLine());

string usernumberStr = Math.Abs(usernumber).ToString();
if (usernumberStr.Length > 3)
{
    Console.Write("Третьей цифры нет");
}
else
{
   Console.Write($"Третья цифра числа: {usernumberStr[2]}"); 
}
