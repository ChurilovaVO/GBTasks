// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
WriteLine("Введите числа через пробел: ");
string str=ReadLine()!;
int[] resultArray=GetArryyFromString(str);
WriteLine($"Количество чисел больше 0 равно {CheckNumbers(resultArray)}");

int[] GetArryyFromString(string Str)
{
    string[] stringArray = Str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] newArray=new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
      newArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return newArray;
}

int CheckNumbers(int[] Ar2)
{
    int count=0;
    for (int i = 0; i < Ar2.Length; i++)
    {
        if (Ar2[i]>0) count++;
    }
    return count;
}