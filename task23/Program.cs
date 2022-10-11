// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите любое целое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Не верное значение! Попробуйте ещё раз: ");
Console.Write(number + " -> ");
for (int index = 1; index <= number; index++)
{
    if (index == number)
    {
        Console.Write(Math.Pow(index, 3));
        break;
    }
    Console.Write(Math.Pow(index, 3) + ", ");
}
