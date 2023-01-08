/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

// Console.Write("введите число: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("введите число: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("введите число: ");
// int c = int.Parse(Console.ReadLine());

// Console.Write("введите число: ");
// int d = int.Parse(Console.ReadLine());

// Console.Write("введите число: ");
// int e = int.Parse(Console.ReadLine());






int[] FillArray(int Length)
{
    int[] array = new int[Length];
    int count = 0;
    while (count < Length)
    {
        Console.Write($"введите {count+1} число: ");
        array[count] = int.Parse(Console.ReadLine());
        count++;
    }
    return array;
}

int PositiveNumberCount (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}



Console.Write("введите количество вводимых чисел: ");
int Length = int.Parse(Console.ReadLine());
int[] array = new int[Length];
array = FillArray(Length);
int result = PositiveNumberCount(array);

Console.Write(result);