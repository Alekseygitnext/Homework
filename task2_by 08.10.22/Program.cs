// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели ");
int DenNedeli = int.Parse(Console.ReadLine());
if (DenNedeli <= 7)
switch (DenNedeli){
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
}
else
{
Console.WriteLine ("Введенa цифра не соответствующая дню недели, от 1 до 7");
}