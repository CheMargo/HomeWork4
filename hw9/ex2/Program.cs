/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int ReadInt(string arg)
{
    Console.Write($"введите {arg} ");
    return int.Parse(Console.ReadLine());
}

int SumOfNaturalNumbersRecurse(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    if (n == (m + 1))
    {
        return (m + n);
    }
    return (m + n + SumOfNaturalNumbersRecurse(m + 1, n - 1));
}


int m = ReadInt("Введите число M");
int n = ReadInt("Введите число N");
if (m > n)
{
    Console.Write($"{m} больше {n}, нельзя посчитать!");
}
else
{
    Console.Write($"Сумма: {SumOfNaturalNumbersRecurse(m, n)}");
}