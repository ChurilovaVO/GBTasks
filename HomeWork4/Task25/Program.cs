// Задача 25: Напишите программу, реализующую метод,
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B с использованием цикла.

// В задаче не использвать стандартный метод Pow!

using static System.Console;
WriteLine("Введите число A: ");
int A=int.Parse(ReadLine()!);
WriteLine("Введите число B: ");
int B=int.Parse(ReadLine()!);

int DegAB=DegreeAB(A,B);
WriteLine(DegAB);


int DegreeAB(int a, int b)
{
    int result=a;
    int count=0;
    
    if (b<1)
    {
        WriteLine("Ошибка: введено ненатуральное число В");
    }
    while(count<b-1)
    {
        result*=a;
        count++;
    }  
    return result;
}
