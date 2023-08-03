// Задача 44
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.

int Fibonacci (int n)
{
    if (n == 0) return 0;
    if (n ==1 || n==2) return 1;
    else return Fibonacci (n-1) + Fibonacci (n-2);
}
//-----------------------------------------------------------
Console.Write("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)  // покажем первые десять чисел Фибоначчи
{
    Console.Write($"{Fibonacci (i)} ");
}

