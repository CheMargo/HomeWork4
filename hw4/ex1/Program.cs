/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

int count = 0;
int result = a;

while (count != b-1)
    {
        result = result * a;
        count++;
    }

Console.WriteLine($"число - {a} в степени {b} = {result}");