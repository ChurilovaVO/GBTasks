// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
WriteLine("Введите размер массива m*n, а также минимальное и максимальное значения через пробел: ");
string[] sizeArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] resultArray = GetRandomArray(int.Parse(sizeArray[0]), int.Parse(sizeArray[1]), int.Parse(sizeArray[2]), int.Parse(sizeArray[3]));
PrintMatrixArray(resultArray);
WriteLine();
FromMaxToMinElemetyArray(resultArray);
PrintMatrixArray(resultArray);

void FromMaxToMinElemetyArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < A.GetLength(1); k++)
            {
                if (A[i, k] > A[i, maxPosition]) maxPosition = k;
            }
            int temp = A[i, j];
            A[i, j] = A[i, maxPosition];
            A[i, maxPosition] = temp;
        }
    }
}



int[,] GetRandomArray(int rows, int columns, int MinValue, int MaxValue)
{
    int[,] NewArray = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i, j] = rand.Next(MinValue, MaxValue + 1);
        }
    }
    return NewArray;
}

void PrintMatrixArray(int[,] inArray)
{
    //WriteLine("В двумерном массиве:");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");

        }
        WriteLine();
    }
}