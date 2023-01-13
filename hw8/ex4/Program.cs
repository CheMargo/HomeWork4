/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using System.Collections.Generic;


int ReadInt(string arg)
{
    Console.Write($"введите {arg} ");
    return int.Parse(Console.ReadLine());
}

int getRandomNumber(List<int> usedNumbers)
{
    if (usedNumbers.Count < 90)
    {
        Random random = new Random();
        int result = 0;
        while (true)
        {
            int newNumber = random.Next(10, 100);
            if (!(usedNumbers.Contains(newNumber)))
            {
                result = newNumber;
                break;
            }
        }
        usedNumbers.Add(result);
        return result;
    }
    else
    {
        return -1;
    }
}

int[,,] GetArray3dimensional(int dimension)
{
    List<int> usedNumbers = new List<int>();
    int[,,] array = new int[dimension, dimension, dimension];
    for (int x = 0; x < dimension; x++)
    {
        for (int y = 0; y < dimension; y++)
        {
            for (int z = 0; z < dimension; z++)
            {
                array[x, y, z] = getRandomNumber(usedNumbers);
            }
        }
    }
    return array;
}

void PrintArray3Dimensional(int[,,] array)
{
    for (int z = 0; z < array.GetLength(0); z++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                Console.Write($"{array[x, y, z]}({x}, {y}, {z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3D = GetArray3dimensional(ReadInt("Введите длину стороны массива"));
PrintArray3Dimensional(array3D);