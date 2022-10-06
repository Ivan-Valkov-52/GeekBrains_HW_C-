int IndexNumber(int number)
{
    int result = 0;
    int index = 1000;
    while (index < number)
    {
        number = number / 10;
    }
    return result = number % 10;
}

Console.Clear();
Console.Write("Введите любое целое число: ");
int number;
while(!int.TryParse(Console.ReadLine(), out number)){
    Console.WriteLine("Вы ввели не корректное значение! Попробуйте ещё раз.");
}
if (Math.Abs(number) > 99)
{
    Console.WriteLine(number + " -> " + IndexNumber(Math.Abs(number)));
}
else
{
    Console.WriteLine(number + " -> третьей цифры нет");
}