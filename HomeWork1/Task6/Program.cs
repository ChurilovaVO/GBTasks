using static System.Console;

WriteLine("Является ли число a четным?");
Write("Введите число a: ");
double a= Convert.ToDouble(ReadLine());

if (a%2==0)
{
    WriteLine("да");
}
else
{
    WriteLine("нет");
}
