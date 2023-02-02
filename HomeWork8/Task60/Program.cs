// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using static System.Console;
WriteLine("Введите размер массива m*n*k через пробел: ");
string[] sizeArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int sizeOneArray = (int.Parse(sizeArray[0])) * (int.Parse(sizeArray[1])) * (int.Parse(sizeArray[2]));
if (sizeOneArray < 90)
{
    int[] resOneArray = GetArrayUniqNumber(sizeOneArray);
    WriteLine();
    int[,,] resultArray = GetRandomArray(resOneArray, int.Parse(sizeArray[0]), int.Parse(sizeArray[1]), int.Parse(sizeArray[2]));
    PrintMatrixArray(resultArray);
}
else WriteLine("Неповторяющихся двузначных чисел недостаточно для заданного размера массива");

int[] GetArrayUniqNumber(int size)
{
    int[] uniqArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int number = rand.Next(10, 100);
        if (uniqArray.Contains(number)) i--;
        else uniqArray[i] = number;
    }
    return uniqArray;
}

int[,,] GetRandomArray(int[] OneAr, int rows, int columns, int volume)
{
    int[,,] newArray = new int[rows, columns, volume];
    int r = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = OneAr[r];
                r++;
            }
        }
    }
    return newArray;
}



void PrintMatrixArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j, k],4} {(i, j, k)} ");
            }
            WriteLine();
        }
    }
}

