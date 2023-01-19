/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/


int ReadInt(string arg)
{
    Console.Write($"введите {arg} ");
    return int.Parse(Console.ReadLine());
}

void PrintNaturalsRecursion(int n)
{
    if (n <= 1)
    {
        Console.Write("1 ");
    }
    else
    {
        Console.Write($"{n} ");
        PrintNaturalsRecursion(n - 1);
    }
}
int number = ReadInt("Введите натуральное число");
PrintNaturalsRecursion(number);