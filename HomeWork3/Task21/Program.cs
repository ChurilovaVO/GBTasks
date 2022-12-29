// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;

WriteLine("Введите ax: ");
int ax = int.Parse(ReadLine()!);
WriteLine("Введите ay: ");
int ay = int.Parse(ReadLine()!);
WriteLine("Введите az: ");
int az = int.Parse(ReadLine()!);

WriteLine("Введите bx: ");
int bx = int.Parse(ReadLine()!);
WriteLine("Введите by: ");
int by = int.Parse(ReadLine()!);
WriteLine("Введите bz: ");
int bz = int.Parse(ReadLine()!);

double xline = bx - ax;
double yline = by - ay;

double xyline = Math.Sqrt(Math.Pow(xline,2) + Math.Pow(yline,2));

double zline = bz - az;
double xyzline = Math.Sqrt(Math.Pow(xyline,2) + Math.Pow(zline,2));

WriteLine($"{xyzline:f2}");
