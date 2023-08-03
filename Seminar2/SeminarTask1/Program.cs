// Напишите программу, которая выводит случайное число из отрезка [10,99] 
// и показывает наибольшую цифру числа

int randomNumber = new Random().Next(10, 100); // генерация случайного числа от 10 до 99
Console.WriteLine($"Случайное число: {randomNumber}");

int firstDigit = randomNumber / 10; // достаем первое число, то есть при делении дробная чатсь отбрасывается
int secondDigit = randomNumber % 10; // достаем второе число, остаток от деления на 10
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшее число: {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшее число: {secondDigit}");
}
