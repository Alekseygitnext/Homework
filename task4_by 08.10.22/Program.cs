// выяснить является ли число четным
Console.Write("Введите целое число:");
int pervoeChislo = int.Parse(Console.ReadLine()?? "0");
if (pervoeChislo% 2==0)
{
    Console.WriteLine ("введено четное число");
}
else
{
   Console.WriteLine ("введено нечетное число");
}