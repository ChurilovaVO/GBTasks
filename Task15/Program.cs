//Программа, где введенное число делится на 7 и 23 без остатка
using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);


if (a%7 == 0 && a%23 == 0)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}

