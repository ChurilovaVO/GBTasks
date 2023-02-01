// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
int[,] resultArray = GetRandomArray();
PrintMatrixArray(resultArray);
int[] sumElementInStringArray = CountSumElementString(resultArray);
//PrintArray(sumElementInStringArray);
int minSumString = MinString(sumElementInStringArray);
//WriteLine(minSumString);
int[] numberString = CheckColString(sumElementInStringArray, minSumString);
WriteLine();
PrintArray(numberString);

int MinString(int[] Ar)
{
    int minValue = Ar[0];
    for (int i = 0; i < Ar.Length; i++)
    {
        if (Ar[i] < minValue)
        {
            minValue = Ar[i];
        }
    }
    return minValue;
}

int[] CheckColString(int[] Ar1, int minVal)
{
    int count = 0;
    for (int k = 0; k < Ar1.Length; k++)
    {
        if (Ar1[k] == minVal)
        {
            count++;  //сколько раз встретится минимальная сумма
        }
    }
    int[] intArray = new int[count];
    int j = 0;
    for (int i = 0; i < Ar1.Length; i++)
    {
        if (Ar1[i] == minVal)
        {
            intArray[j] = i + 1;
            j++;
        }
    }
    return intArray;
}


int[] CountSumElementString(int[,] A)
{
    int[] newAr = new int[A.GetLength(0)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            sumElement += A[i, j];
        }
        newAr[i] = sumElement;
    }
    return newAr;
}


int[,] GetRandomArray()
{
    int[,] newArray = new int[4, 4];
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

void PrintArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        Write($"{Arr[i]} - строка, ");
    }
    WriteLine($"{Arr[Arr.Length - 1]} - строка");
}