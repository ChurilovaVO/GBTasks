//Программа, которая выводит знак сравнения двух чисел
using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a>b)
{
    WriteLine(">");
}
else if (a<b)
{
    WriteLine("<");
}
else
{
    WriteLine("=");
}

