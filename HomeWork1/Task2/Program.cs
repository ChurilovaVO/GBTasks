using static System.Console;

WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
int max = a;

if (a<b)
{
    WriteLine($"max={b}, min={a} ");
}
else WriteLine($"max={a}, min={b} ");