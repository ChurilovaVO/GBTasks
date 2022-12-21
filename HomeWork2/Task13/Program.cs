// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

int A = a;
int discharge = 1;
int remains = 10;
int result = 0;

if (a>99) 
{while (999 < A)
{
    discharge = discharge * 10;
    remains = remains * 10;
    A = A / 10;
}
result = a % remains / discharge;
WriteLine(result);
}
else
{
    WriteLine("Третьей цифры нет");
}
