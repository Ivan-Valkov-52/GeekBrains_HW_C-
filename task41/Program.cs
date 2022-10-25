
Nullable<int> InputNumber()
{
    string text = "";
    int num;
    while (true)
    {
        text = Console.ReadLine();
        if (int.TryParse(text, out num))
        {
            break;
        }
        else
        {
            if (text.ToLower() == "exit")
            {
                return null;
            }
            Console.Write("Попробуй ещё раз: ");
        }
    }
    return num;
}

List<int> GetList()
{
    List<int> array = new List<int>();
    while (true)
    {
        Nullable<int> num = InputNumber();
        if (num.HasValue)
        {
            array.Add(num.Value);
        }
        else
        {
            break;
        }
    }
    return array;
}

int PositiveListElement(List<int> array){
    int count = 0;
    foreach (int el in array)
    {
        if(el > 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите целые числа: ");
List<int> arr = GetList();
Console.Write(string.Join(", ", arr) + " -> " + PositiveListElement(arr));