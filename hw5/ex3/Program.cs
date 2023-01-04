/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

float[] FillArray(float[] collection)
{
    float Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(100,1000);
        index++;
    }
    return collection;
}

void PrintArray(float[] collection)
{
    int count = collection.Length;
    int index = 0;
    while(index < count)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
}

float findMax (float[] collection)
{
    float maxNum = collection[0];
    for(int counter = 1; counter < collection.Length; counter++)
    {
        if (collection[counter] > maxNum)
        {
            maxNum = collection[counter];
        }
    }

    return maxNum;
}
float findMin (float[] collection)
{
    float minNum = collection[0];
    for(int counter = 1; counter < collection.Length; counter++)
    {
        if (collection[counter] < minNum)
        {
            minNum = collection[counter];
        }
    }

    return minNum;
}

float[] examplArray = new float[5];
examplArray = FillArray(examplArray);
PrintArray(examplArray);
float max = findMax(examplArray);
float min = findMin(examplArray);
float diff = max - min;


Console.Write($"\nРазница между максимальным ({max}) и минимальным ({min}) элементами массива = {diff}");