// Задача 25. 
//Напишите программу, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int GetPow(int number1, int number2) //метод для возведения числа в степень
{
    int resalt = 1;
   for (int i = 0; i < number2; i++)
   {
    resalt = number1 * resalt;
   }
          return resalt;
} 

bool Prowerka (int number) // метод для проверки на отрицательную степень
{
    if (number < 0) 
    {
        Console.Write("Степень должна быть положительной");  
        return false;
    }
    else return true;
}

//----------------------------------------------------------------------------------

Console.Write("Введите число А: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = int.Parse(Console.ReadLine());

if (Prowerka(number2)) //если при проверке правда, то далее выполняется GetPow, если ложь товыполняется только проверка
{
  Console.Write($"Число А в степени В равно: {GetPow(number1, number2)}");  
}