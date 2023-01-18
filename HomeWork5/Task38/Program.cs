// Задача 38: Напишите программу реализующую методы 
// формирования массива, заполненного случайными 
// вещественными числами и вычисления разницы между
//  максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
double[] Array=GetArray(size);
PrintArray(Array);

double min = SearchMinValue(Array);
double max= SearchMaxValue(Array);
WriteLine($"максимальное зачение ={max:f1}, минимальное значение ={min:f1}");

double result = max-min;
WriteLine($"Разница между max и min равна {result:f1}");


double[] GetArray(int A)
{
    double[] NewArray=new double[A];
    Random rand = new Random();
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i]=rand.NextDouble() * 40-20;
    }
    return NewArray;
}



void PrintArray(double[] Arr)
{
    Write("[");
    for (int i = 0; i < Arr.Length-1; i++)
    {
        //Write($"{Arr[i]}, ");
        Write("{0:0.0} ", Arr[i] );
    }
    Write("{0:0.0}", Arr[Arr.Length-1]);
    WriteLine("]");
}


double SearchMinValue (double[] Ar1)
{
    double minValue=0;
    
    for (int i = 0; i < Ar1.Length; i++)
    {
         if (Ar1[i]<minValue) minValue=Ar1[i];
    }
    return minValue;
}


double SearchMaxValue(double[] Ar2)
{
    double maxValue=0;
    for (int i = 0; i < Ar2.Length; i++)
    {
       if(Ar2[i]>maxValue) maxValue=Ar2[i];
    }
    return maxValue;
}