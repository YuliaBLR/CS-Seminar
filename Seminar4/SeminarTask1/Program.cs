// Задача 19
//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

bool IsPalindrome(int number)
{
    if (number < 0) return false; // проверка отрицательное ли число

    int revNumber = 0;
    int tempnumber = number;
    while (tempnumber != 0)
    {
        int temp = tempnumber % 10; // достаем крайнюю правую цифру исходного числа
        revNumber = (revNumber * 10) + temp; // формируем реверсивное число
        tempnumber = tempnumber / 10; // уменьшение исходного числа
    }
    if (revNumber == number)
    {
        return true;
    }
    return false;
}

//----------------------------------------------

Console.Write(IsPalindrome(number: -16461));