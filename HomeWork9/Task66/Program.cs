// Задача 66: Напишите программу, которая реализует 
// рекурсивный метод нахождения суммы натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;

WriteLine("Введите число M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите число N: ");
int N = int.Parse(ReadLine()!);
int result = GetSumElements(M, N);
WriteLine(result);

int GetSumElements(int num1, int num2)
{
    if (num2 < num1) return 0;
    else return num2 + GetSumElements(num1, num2 - 1);
}
