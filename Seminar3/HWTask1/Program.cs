// Задача 19
// Напишите программу, которая принимает  на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void GetPalindrome(int number)
{
int numbertemp = number;
if (Math.Abs(number) < 10000 || Math.Abs(number) > 99999)
{
    Console.Write("Число не пятизначное");
}
else
{
    int number5 = numbertemp % 10; numbertemp = numbertemp / 10; 
    int number4 = numbertemp % 10; numbertemp = numbertemp / 10; 
    int number3 = numbertemp % 10; numbertemp = numbertemp / 10; 
    int number2 = numbertemp % 10; numbertemp = numbertemp / 10; 
    int number1 = numbertemp % 10; numbertemp = numbertemp / 10; 

if (number > 9999 && number < 100000 && number1 == number5 && number2 == number4)
{

    Console.Write("Число является полиндромом");  
}
else
{
    Console.Write("Число не является полиндромом"); 
}
}
}

//------------------------------------------------------------

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
GetPalindrome(number);
