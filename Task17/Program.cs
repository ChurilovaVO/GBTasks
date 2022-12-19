//программа, где одно число является квадратом другого
using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a == b*b)
{
   WriteLine($"Число {a} явялется квардратом числа {b}"); 
}
else if (b == a*a)
{
   WriteLine($"Число {b} явялется квардратом числа {a}"); 
}
else
{
    WriteLine("Ни одно число не явялется квдратом другого");
}

