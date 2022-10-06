Console.Clear();
Console.Write("Введите трехзначное число: ");
int number;
while(!int.TryParse(Console.ReadLine(), out number)){
    Console.WriteLine("Вы ввели не корректное значение! Попробуйте ещё раз.");
}
bool log = true;
while (log)
{
    if (99 < Math.Abs(number) && Math.Abs(number) < 1000)
    {
        int value = (number / 10) % 10;
        Console.WriteLine(number + " -> " + Math.Abs(value));
        log = false;
    }
    else
    {
        Console.WriteLine("Ввели не верное значение!");
        number = int.Parse(Console.ReadLine());
    }
}


