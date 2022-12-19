// программа, гд два стрелка без промаха стреляют по банкам и попадают в последнюю оба
using static System.Console;

WriteLine("Первый стрелок сбил такое количество банок: ");
int a = int.Parse(ReadLine()!);
WriteLine("Второй стрелок сбил такое количество банок: ");
int b = int.Parse(ReadLine()!);

WriteLine("Одну банку стрелки попали одновременно"); 
WriteLine("Общее количество сбитых банок:"); 
WriteLine(a + b - 1);

