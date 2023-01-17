// Задача 29: Напишите программу, реализующую метод, 
// который формирует массив случайных целых чисел 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
int[] Array = GetArray(8);
PrintArray(Array);



int[] GetArray(int size)
{
    int[] Arr=new int[size];
    for (int i=0; i < Arr.Length; i++)
    {
        Arr[i]=new Random().Next(0,100);
    }
    return Arr;
}

void PrintArray(int[] a)
{
   Write("[");
    for (int i=0; i < a.Length-1; i++)
    {
        Write($"{a[i]}, ");
    }
    WriteLine($"{a[a.Length-1]}]");
}