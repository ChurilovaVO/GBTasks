// Задача 50. Напишите программу реализующую метод,
// принимающий позиции элемента в двумерном массиве, 
// и возвращающий значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

WriteLine("Введите размер массива m*n, а также минимальное и максимальное значения через пробел: ");
string[] sizeArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] resultArray = GetRandomArray(int.Parse(sizeArray[0]), int.Parse(sizeArray[1]), int.Parse(sizeArray[2]), int.Parse(sizeArray[3]));

WriteLine("Введите координаты элемента в массиве через пробел: ");
int[] IndexElement = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); //Convert.ToInt32
string resultValue = CheckElementInMatrix(resultArray, IndexElement[0], IndexElement[1]);
WriteLine();
PrintMatrixArray(resultArray);
WriteLine();
PrintArray(IndexElement, resultValue);
WriteLine();


string CheckElementInMatrix(int[,] A, int indexRow, int indexColumn)
{
    string element = "0";
    if (A.GetLength(0) > indexRow && A.GetLength(1) > indexColumn)
    {
        for (int i = 0; i <= indexRow; i++)
        {
            for (int j = 0; j <= indexColumn; j++)
            {
                element = Convert.ToString(A[i, j]);
            }
        }
    }
    else
    {
        element = "отсутствует";
    }
    return element;
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
    WriteLine("В двумерном массиве:");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");

        }
        WriteLine();
    }
}

void PrintArray(int[] Arr, string resValue)
{
    Write("Значение элемента с заданными координатами: [");
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        Write($"{Arr[i]}, ");
    }
    WriteLine($"{Arr[Arr.Length - 1]}] -> {resValue}");
}
