// Показать числа от -N до N
Console.Write("Введите число:");
double Chislo = double.Parse(Console.ReadLine() ?? "0");
double b = (Chislo * -1);
if (Chislo > 0)
{
    while (b <= Chislo)
    {
        Console.Write(" {0}", b);
        b++;
    }
}
else
{
    while (Chislo <= b)
    {
        Console.Write(" {0}", Chislo);
        Chislo++;
    }
}