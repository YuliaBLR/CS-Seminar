// Задача 11. 
// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000); // генерация случайного числа от 100 до 999
Console.WriteLine($"Случайное число: {randomNumber}");

int firstDigit = randomNumber / 100; // достаем первое число, то есть при делении дробная чатсь отбрасывается
int thirdDigit = randomNumber % 10; // достаем второе число, остаток от деления на 10

Console.Write(firstDigit*10 + thirdDigit);
