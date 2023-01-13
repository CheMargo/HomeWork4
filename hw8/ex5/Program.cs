/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillSpiral(int[,] array)
{
    int rY = 0;
    int rX = 0;
    int count = 1;
    int sizeX = array.GetLength(1);
    int sizeY = array.GetLength(0);
    int summ = sizeX * sizeY;
    while (sizeY > 0)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
            {
                if (y == 0 && x < sizeX - rX && count <= summ)
                    array[y + rY,x + rX] = count++;
                if (y == 1 && x < sizeY - rY && x != 0 && count <= summ)
                    array[x + rY,sizeX - 1] = count++;
                if (y == 2 && x < sizeX - rX && x != 0 && count <= summ)
                    array[sizeY - 1,sizeX - (x + 1)] = count++;
                if (y == 3 && x < sizeY - (rY + 1) && x != 0 && count <= summ)
                    array[sizeY - (x + 1),rY] = count++;
            }
        }
        sizeY--;
        sizeX--;
        rY += 1;
        rX += 1;
    }
}
int[,] array = new int[4, 4];
FillSpiral(array);
PrintArray(array);