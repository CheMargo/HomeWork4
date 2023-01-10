/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

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

string AVGColumn (int[,] array)
{
    string result = string.Empty;
    for (  int column = 0; column < array.GetLength(1); column++)   //столбцы
    {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)          //строки
        {
            sum += array[row,column];
        
        }
    result += sum / array.GetLength(0) + " ";
    }
    return result;
 
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
string result = AVGColumn(array);

System.Console.WriteLine(result);