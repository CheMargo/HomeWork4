/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/


void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection
    [index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while(index < count)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

