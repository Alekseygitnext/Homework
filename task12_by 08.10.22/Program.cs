// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");

if (Chislo / 100 != 0)
{
    while (Chislo / 100 >= 10)
    {
        Chislo = Chislo / 10;
        Console.WriteLine(Chislo);
    }
    Console.Write("третье число ");
    Console.WriteLine(Chislo % 10);

}
else
{
    Console.WriteLine("Числа нет");
}