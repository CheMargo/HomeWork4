/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

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

int sumOdds (int[] collection)
{
    int index = 0;
    int length = collection.Length;
    int sum = 0;
     while(index < length)
    {
        if(collection[index] % 2 != 0)
        {
            sum = sum + collection[index];
        }
        index++;
    }
    return sum;
}

int[] examplArray = new int[5];
examplArray = FillArray(examplArray);
PrintArray(examplArray);
int result = sumOdds(examplArray);
Console.Write($"сумма нечетных чисел = {result} ");
