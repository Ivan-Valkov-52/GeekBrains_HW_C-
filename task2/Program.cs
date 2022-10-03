string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
bool text = true;
while (text)
{
    int numberDay = int.Parse(Console.ReadLine());
    if (1 <= numberDay && numberDay <= 7)
    {
        Console.WriteLine("День недели: " + day[numberDay - 1]);
        text = false;
    }
    else
    {
        Console.WriteLine("Ввели неверное число, попробуйте снова!");
    }
}
