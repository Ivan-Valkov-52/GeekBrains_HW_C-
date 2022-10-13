// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. 
// [1,0,1,1,0,1,0,0]

int [] ArrayRandom()
{
    int[] masiv = new int[8];
    for (int i = 0; i < masiv.Length; i++)
    {
        masiv[i] = new Random().Next(0, 2);
    }
    return masiv;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
            break;
        }
        Console.Write(array[i] + ", ");
    }
}

Console.Clear();
int[] array;
array = ArrayRandom();
PrintArray(array);
