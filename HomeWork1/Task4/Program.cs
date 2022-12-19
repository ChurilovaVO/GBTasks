using static System.Console;

WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число: ");
int c = Convert.ToInt32(ReadLine());
int max = a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Write("max= ");
WriteLine(max);
