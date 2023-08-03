// Задача 18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y). 

void GetQuarter (int quarter)
{
    if (quarter < 1 || quarter > 4)
    {
        Console.Write("Такой четверти нет");
    }
    else
    {
        if (quarter == 1)
        {
            Console.Write("x > 0 и y > 0");
        }
        if (quarter == 2)
        {
            Console.Write("x < 0 и y > 0");
        }
        if (quarter == 3)
        {
            Console.Write("x < 0 и y < 0");
        }
        if (quarter == 4)
        {
            Console.Write("x > 0 и y < 0");
        }
    }
}

//---------------------------------------------------------

Console.Write("Введите номер четверти: ");
int q = int.Parse(Console.ReadLine());
GetQuarter(q);


