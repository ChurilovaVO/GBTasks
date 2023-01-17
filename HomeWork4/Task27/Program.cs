// Задача 27: Напишите программу, реализующую метод, 
// который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
WriteLine("Введите число: ");
int number=int.Parse(ReadLine()!);
int sum=SumNum(number);
WriteLine(sum);



int SumNum(int a)
{
    int result=0;
    while (a>1)
    {
        int num=a%10;
        result+=num;
        a= a/10;
    }
    return result;
}
