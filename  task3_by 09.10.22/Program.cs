// Задать номер четверти, показать
Console.Write("Введите номер четверти: ");
int chetvert = int.Parse(Console.ReadLine() ?? "0");
if (chetvert <= 4)
    switch (chetvert)
    {
        case 1:
            Console.WriteLine("0<X<infinity, 0<Y<infinity");
            break;
        case 2:
            Console.WriteLine("-infinity<X<0, 0<Y<infinity");
            break;
        case 3:
            Console.WriteLine("-infinity<X<0, -infinity<Y<0");
            break;
        case 4:
            Console.WriteLine("0<X<infinity, -infinity<Y<0");
            break;
    }
else
{
    Console.WriteLine("Введен неправильный номер четверти");
}