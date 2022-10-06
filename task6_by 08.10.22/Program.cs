// Показать четные числа от 1 до N
Console.Write("Введите число:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Chislo; i = i + 1)
{
    if (!(i % 2 == 1))
        Console.Write($" {i}");
}