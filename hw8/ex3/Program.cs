/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Эти матрицы нельзя перемножить!");
        }

        var matrixC = new int[matrixA.GetLength(1), matrixB.GetLength(0)];

        for (var i = 0; i < matrixA.GetLength(1); i++)
        {
            for (var j = 0; j < matrixB.GetLength(0); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }


int height = ReadInt("количество столбцов в матрице:");
int width = ReadInt("количество строк в матрице:");
int[,] matrixA = GetArray(height, width);
int[,] matrixB = GetArray(height, width);
PrintArray(matrixA);
PrintArray(matrixB);
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
Console.WriteLine("произведение матриц:");
PrintArray(matrixC);