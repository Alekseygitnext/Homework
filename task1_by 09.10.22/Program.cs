// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int DenNedeli = int.Parse(Console.ReadLine() ?? "0");
if (DenNedeli <= 7)
    switch (DenNedeli)
    {
        case 1:
            Console.WriteLine("Понедельник - рабочий день");
            break;
        case 2:
            Console.WriteLine("Вторник - рабочий день");
            break;
        case 3:
            Console.WriteLine("Среда - рабочий день");
            break;
        case 4:
            Console.WriteLine("Четверг - рабочий день");
            break;
        case 5:
            Console.WriteLine("Пятница - рабочий день");
            break;
        case 6:
            Console.WriteLine("Суббота - выходной");
            break;
        case 7:
            Console.WriteLine("Воскресенье - выходной");
            break;
    }
else
{
    Console.WriteLine("Введенa цифра не соответствующая дню недели, от 1 до 7");
}