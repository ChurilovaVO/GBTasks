// Задача 47. Напишите программу реализующую метод, 
// который возвращает массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using static System.Console;
Clear();

WriteLine("Введите размер массива m*n, а также минимальное и максимальное значение через пробел: ");
string[] sizeArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[,] resultArray = GetDoubleRandomArray(int.Parse(sizeArray[0]), int.Parse(sizeArray[1]), int.Parse(sizeArray[2]), int.Parse(sizeArray[3]));
PrintMatrixDoubleArray(resultArray);


double[,] GetDoubleRandomArray(int rows, int columns, int MinValue, int MaxValue)
{
    double[,] NewArray = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i,j] = rand.Next(MinValue, MaxValue) + rand.NextDouble();
        }
    }
    return NewArray;
}

void PrintMatrixDoubleArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //Write($"{inArray[i,j], 3} ");
        Write($"{Math.Round(inArray[i, j], 1), 5} ");

        }
        WriteLine();
    }
    
}