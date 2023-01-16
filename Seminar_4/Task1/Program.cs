//метод, гда вводится число А и выводится произведение от 1 до А

using static System.Console;
Write("Input number: ");
int number = int.Parse(ReadLine()!);
int comp=GetComp(number);
WriteLine($"Comp number 1...A = {comp}");


int GetComp(int A)
{
    int resultComp=1;
    while(A>0)
    {
        resultComp=resultComp*A;
        A--;  
    }
    return resultComp;
}
