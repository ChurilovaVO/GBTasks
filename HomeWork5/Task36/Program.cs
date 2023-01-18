// Задача 36: Напишите программу реализующую методы 
// формирования массива, заполненного случайными числами
//  и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);

int[] Array=GetArray(size);
PrintArray(Array);
int result = SumEl(Array);
WriteLine(result);


int[] GetArray(int S)
{
    int[] NewArray=new int[S];
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i]= new Random().Next(-10,10);
    }
    return NewArray;
}


int SumEl(int[] A)
{
    int Sum=0;
    for (int i = 0; i < A.Length; i++)
    {
        if (i%2!=0)
        {
            Sum+=A[i];
        }
    }
    return Sum;
}


void PrintArray(int[] Arr)
{
    Write("[");
    for (int i = 0; i < Arr.Length-1; i++)
    {
        Write($"{Arr[i]}, ");
    }
    WriteLine($"{Arr[Arr.Length-1]}]");
}
    