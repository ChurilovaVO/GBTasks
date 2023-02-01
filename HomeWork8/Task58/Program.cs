// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
int[,] resultArray1 = GetRandomArray();
int[,] resultArray2 = GetRandomArray();
PrintMatrixArray(resultArray1);
WriteLine();
PrintMatrixArray(resultArray2);
WriteLine();
int[,] newMatrixArray=MultiplyMatrix(resultArray1,resultArray2);
PrintMatrixArray(newMatrixArray);


int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                newMatrix[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return newMatrix;
}

int[,] GetRandomArray()
{
    int[,] newArray = new int[2, 2];
    Random rand = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rand.Next(0, 6);
        }
    }
    return newArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}