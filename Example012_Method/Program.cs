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
    while(i < count)
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


string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "k");
Console.WriteLine(res);