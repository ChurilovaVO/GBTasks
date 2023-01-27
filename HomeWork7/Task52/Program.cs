// Задача 52. Напишите программу реализующую методы, 
// формирования двумерного массива и массива средних 
// арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();

WriteLine("Введите размер массива m*n, а также минимальное и максимальное значения через пробел: ");
string[] sizeArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] resultArray = GetRandomArray(int.Parse(sizeArray[0]), int.Parse(sizeArray[1]), int.Parse(sizeArray[2]), int.Parse(sizeArray[3]));
PrintMatrixArray(resultArray);
WriteLine();
double[] resultSum = SumMeanArithValueColumns(resultArray);
PrintArray(resultSum);

double[] SumMeanArithValueColumns(int[,] A)
{
    double[] SumColums = new double[A.GetLength(1)];
    SumColums[0] = 0;
    int k = 0;
    for (int j = 0; j < A.GetLength(1); j++)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            SumColums[k] = (SumColums[k] + A[i, j]);
        }
        SumColums[k]=SumColums[k]/A.GetLength(0);
        k++;
    }
    return SumColums;
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
    WriteLine("В заданном массиве:");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");

        }
        WriteLine();
    }
}

void PrintArray(double[] Arr)
{
    Write("Среднее арифметическое каждого столбца: [");
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        Write($"{Math.Round(Arr[i],1)}, ");
    }
    WriteLine($"{Math.Round(Arr[Arr.Length - 1],1)}] ");
}