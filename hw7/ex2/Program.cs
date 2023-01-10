/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

//за позицию 1,1 мы принимаем индекс [0,0]
int ReadInt()
    {
        return int.Parse(Console.ReadLine());
    }

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (  int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(1000);
        }
    }
    return array;
}

void GetArrayElement (int[,] array)
{
    Console.Write("введите индекс двумерного массива разделяя числа пробелом: ");
    string[] num = Console.ReadLine().Split(' ');
               int a = int.Parse(num[0]);
               int b = int.Parse(num[1]);
    
    if(a > array.GetLength(0) | b > array.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"'элемент массива с заданым индексои имеет значение: {array[a,b]}'");
    }
 
}

void PrintArray (int[,] array)
{
     for (  int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int firstLength = ReadInt();
int secondLength = ReadInt();

int[,] array = GetArray(firstLength, secondLength);

PrintArray(array);
System.Console.WriteLine();
GetArrayElement(array);

