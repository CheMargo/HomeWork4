/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */
 
int ReadInt(string arg)
{
    Console.Write($"введите {arg} ");
    return int.Parse(Console.ReadLine());
}

int AkkermanRecurse(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanRecurse(m - 1, 1);
    }
    return AkkermanRecurse(m - 1, AkkermanRecurse(m, n - 1));
}

int n = ReadInt("Введите число N");
int m = ReadInt("Введите число M");

Console.WriteLine(AkkermanRecurse(m, n));