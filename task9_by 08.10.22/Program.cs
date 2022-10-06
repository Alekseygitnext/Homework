// Дано число из отрезка [10,99]. Показать наибольшую цифру числа
int numberA = new Random().Next(1, 100);//1 2 3 4...99
Console.WriteLine($"Число {numberA}");
int firstnumber = (numberA % 10);
int secondnumber = (numberA / 10);
Console.WriteLine($"первое число {firstnumber}, второе число {secondnumber}");
Console.WriteLine("Max: " + Math.Max(firstnumber, secondnumber));