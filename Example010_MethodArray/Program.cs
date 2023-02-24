int[] array = new int[10];        //Создаем массив, который состоит из 10 элементов.

void FillArray(int [] collection) // Метод, который заполняет массив.
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(10);
        index++;
    }
}

void PrintArray(int[] col) //Метод, который выводит массив.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}



FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 444);
Console.WriteLine(pos);

// int n = array.Length;
// int find = 3;

// int index = 0;

// while (index <n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;         // index = index +1;
// }