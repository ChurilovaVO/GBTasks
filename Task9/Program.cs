using static System.Console;
Clear();
int number=new Random().Next(10,100);
WriteLine(number);
WriteLine(number/10>number%10?number/10:number%10);
if(number/10>number%10)
{
    WriteLine(number/10);
}
else
{
    WriteLine(number%10);
}

