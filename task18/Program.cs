// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Ввели не корректные данные!");
switch (number)
{
    case 1:
        Console.WriteLine("X > 0 и Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0 и Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0 и Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0 и Y < 0");
        break;
    default:
        Console.WriteLine("Ввели не корректное значение!");
        break;
}
