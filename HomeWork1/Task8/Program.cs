using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int count = 1;

while (count <= a)
{
   if (count % 2 == 0) 
    {
       Write(count);
    }
count = count + 1;
}