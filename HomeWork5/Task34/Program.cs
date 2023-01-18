// Задача 34: Напишите программу, реализующую методы 
// формирования массива, заполненного случайными 
// положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
Check(size);

int[] Array=GetArray(size);
int ColEvenNum=GetCol(Array);
PrintArray(Array);
WriteLine(ColEvenNum);


void Check(int S)
{
    if(S<1)
    {
        WriteLine("Ошибка");
    }
}


int[] GetArray(int a)
{
    int[] NewArray = new int[a];
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i]=new Random().Next(100,1000);
    }
    return NewArray;
}


int GetCol (int[] Arr)
{
    int count =0;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i]%2==0)
    {
        count++;
    }
}
    return count;
}




















void PrintArray(int[] A)
{
    Write("[");
    for (int i = 0; i < A.Length-1; i++)
    {
        Write($"{A[i]}, ");
    } 
     WriteLine($"{A[A.Length-1]}]");
}
  
   