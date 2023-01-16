//метод, гда вводится число А и выводится количество цифр в числе А

using static System.Console;
WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);
int result = ColNum(num);

WriteLine($"Количество цифр в числе {num} равно {result}");


int ColNum(int A)
{
    int Col =0;

    while (A>1)
    {
        Col=Col+1;
        A=A/10;
    }
    return Col;
}
