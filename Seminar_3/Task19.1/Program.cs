using static System.Console;
Clear();

WriteLine("Введите х ");
int x = Convert.ToInt32(ReadLine());
WriteLine("Введите y ");
int y = Convert.ToInt32(ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        WriteLine("Точка находится в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        WriteLine("Точка находится во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        WriteLine("Точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        WriteLine("Точка находится в четвертой четверти");
    }
else
{
    WriteLine("Точка попадает на ось координат");
}
}