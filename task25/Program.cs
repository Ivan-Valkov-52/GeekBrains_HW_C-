// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

int Value(int num)
{
    int count = 1;
    int index = 10;
    while (index < Math.Abs(num))
    {
        count++;
        index *= 10;
    }
    return count;
}

Console.Clear();
Console.Write("Введите любое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Введите корректное значение: ");
Console.WriteLine(number + " -> " + Value(number));