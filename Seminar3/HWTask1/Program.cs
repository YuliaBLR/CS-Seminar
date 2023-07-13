// Задача 19
// Напишите программу, которая принимает  на вход пятизначное число 
// и проверяет, является ли оно палиндромом.




//----------------------------------------------------------------

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());



if (Math.Abs(number) > 9999 && Math.Abs(number) < 100000)
{
    int number5 = number % 10;
    int number4 = number % 100;
    int number3 = number % 1000;
    int number2 = number % 10000;
    int number1 = number % 100000;

    if (number1 == number5 && number2 == number4 && number > 0)
    {
        
        Console.Write("Число является полиндромом");
    }
    else
    {
       Console.Write("Число не является полиндромом"); 
    }
}
else
{
    Console.Write("Число не пятизначное");
}








  
