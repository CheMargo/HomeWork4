/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(100,1000);
        index++;
    }
    return collection;
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while(index < count)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
}

int countEvenNumbers (int[] collection)
{
    int index = 0;
    int length = collection.Length;
    int countEvens = 0;
     while(index < length)
    {
        if(collection[index] % 2 == 0)
        {
            countEvens++;
        }
        index++;
    }
    return countEvens;
}

int[] examplArray = new int[5];
examplArray = FillArray(examplArray);
PrintArray(examplArray);
int result = countEvenNumbers(examplArray);
Console.Write($"количество четных чисел = {result} ");

