/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
void SortRows (int[,] array)
{
    int temp = 0;
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for (int i = 0; i + 1 < array.GetLength(1); i++) 
        {
            for (int j = 0; j + 1 < array.GetLength(1) - i; j++) 
            {
                if (array[row,j + 1] < array[row,j]) 
                {
                    temp = array[row, j];
                    array[row, j] = array[row, j + 1];
                    array[row, j + 1] = temp;
                }
            }
        }        
    }
}

int[,] array = GetArray(ReadInt("First Lendth"), ReadInt("Second Length"));
PrintArray(array);
SortRows(array);
Console.WriteLine("Sorted array:\n");
PrintArray(array);