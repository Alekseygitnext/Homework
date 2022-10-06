// Показать вторую цифру трехзначного числа
Console.Write("Введите трёхзначное числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
string str = Chislo.ToString();
Console.WriteLine(str[1]);