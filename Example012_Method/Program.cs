// Вид 1
void Method1()
{
    System.Console.WriteLine("Автор Константин");
}

// Method1();

// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Method2("Текст сообщения!");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method2_1(msg: "Текст!", count: 4);
// Method2_1(count: 2, msg: "Новый текст!");



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);



// Вид 4


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "k");
// Console.WriteLine(res);

// Цикл for на базе 4-го метода

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "k");
// Console.WriteLine(res);

// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Задача. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К"б а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруССкого короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result =result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

//  Упорядочивание массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
Sort(arr);
PrintArray(arr);

// Д/з после лекции: В каком виде упорядочивание можно выполнить в обратном порядке, от большего к меньшему

