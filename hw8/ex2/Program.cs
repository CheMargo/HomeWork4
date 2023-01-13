/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int ReadInt(string arg)
    {
        Console.Write($"введите {arg} ");
        return int.Parse(Console.ReadLine());
    }

int[,] GetArray (int firstlength, int secondLength) 
{
    int[,] array = new int[firstlength, secondLength];

    Random random = new Random();

    for (  int i = 0; i < firstlength; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
     for (  int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void BubbleSortArray (int[] array)
{
    int temp = 0;
    for (int i = 0; i + 1 < array.Length; i++) 
        {
            for (int j = 0; j + 1 < array.Length - i; j++) 
            {
                if (array[j + 1] < array[j]) 
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }        
}

int FindLowestSumRow(int[,] array)
{
    int[] RowSum = new int[array.GetLength(1)];

    for (int row = 0; row < array.GetLength(0); row++)
    {
        int Sum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Sum += array[row,column];
        }
        RowSum[row] = Sum;
        Console.WriteLine($"row {row} sum {Sum}");
    }
    BubbleSortArray(RowSum);
    return RowSum[0];
}


int[,] array = GetArray(ReadInt("First Lendth"), ReadInt("Second Length"));
PrintArray(array);
Console.WriteLine($"Lowest Sum row is {FindLowestSumRow(array)}");