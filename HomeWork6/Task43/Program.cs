//Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;

WriteLine("Введите значения k1 и b1: ");
Values y1 = GetValuesFromString(ReadLine()!);
WriteLine("Введите значения k2 и b2: ");
Values y2 = GetValuesFromString(ReadLine()!);

double resultX= ((y2.b)-(y1.b))/((y1.k)-(y2.k));
double resultY=((y1.k)*resultX+(y1.b));
WriteLine($"Координаты точки пересечения двух прямых ({resultX},{resultY})");


Values GetValuesFromString(string Str)
{
    Values res = new Values();
    string[] par = Str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.k = int.Parse(par[0]);
    res.b = int.Parse(par[1]);
    return res;
}


struct Values
{
    public double b;
    public double k;
}

