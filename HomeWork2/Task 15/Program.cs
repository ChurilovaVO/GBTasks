﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Console;
Write("Введите цифру дня недели: ");
int a=int.Parse(ReadLine()!);

if (a>0 && a<8)
{
    if (a==6 | a==7)
    {
        WriteLine("да, выходной");
    }
    else
    {
        WriteLine("нет, не выходной");
    }
}
else
{
WriteLine("Такого дня недели не существует");
}
