//Задача 24
//Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

 int GetSum (int limit)
 {
    int sum = 0;
    for (int i = 0; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
 }

 //------------------------------------------------

 int sum = GetSum(limit: 4);
 Console.Write(sum);