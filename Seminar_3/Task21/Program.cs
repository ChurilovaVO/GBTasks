//bool isParse=int.TryParse(ReadLine(),out int 1))
//if (!isParse)
//вывести квадраты чисел от 1 до N

using static System.Console;

WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int count = 1;

while (count <= n)
{
    WriteLine(count * count);
    count++;
}
