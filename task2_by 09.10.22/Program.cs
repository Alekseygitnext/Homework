// По двум заданным числам проверить является ли одно квадратом второго
Console.Write("Введите первое число:");
double pervoeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число:");
double vtoroeChislo = double.Parse(Console.ReadLine()?? "0");
double kvadrat = Math.Pow(vtoroeChislo, 2);
if (pervoeChislo == kvadrat)
{
    Console.WriteLine ("Первое число квадрат второго");
}
else
{
    Console.WriteLine ("Первое число не квадрат второго");
}