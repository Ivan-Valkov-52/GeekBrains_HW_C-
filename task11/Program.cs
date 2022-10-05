// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSeconde = int.Parse(Console.ReadLine());
if (numberFirst != 0)
{
    if (numberSeconde % numberFirst == 0)
    {
        Console.Write($"{numberSeconde}, {numberFirst} -> кратно");
    }
    else
    {
        Console.Write($"{numberSeconde}, {numberFirst} -> не кратно, остаток {numberSeconde % numberFirst}");
    }
} else {
    Console.WriteLine("Делить на 0 нельзя!");
}