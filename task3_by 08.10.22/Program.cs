// Найти максимальное из трех чисел
Console.Write("Введите первое число:");
double pervoeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число:");
double vtoroeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Введите третье число:");
double tretieChislo = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine (Math.Max(pervoeChislo, Math.Max(vtoroeChislo, tretieChislo)));
