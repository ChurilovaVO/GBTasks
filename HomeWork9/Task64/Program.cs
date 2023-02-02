// Задача 64: Напишите программу, которая реализует 
// рекурсивный метод вывода всех натуральных числел в 
// промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
WriteLine("Введите число N: ");
int number = int.Parse(ReadLine()!);
Write($"N = {number} -> \"");
PrintNumbers(number);


void PrintNumbers(int num)
{
    if (num == 1) Write($"{num}\"");
    else
    {
        Write($"{num}, ");
        PrintNumbers(num - 1);
    }
}