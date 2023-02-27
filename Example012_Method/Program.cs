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

Method2_1(msg: "Текст!", count: 4);
Method2_1(count: 2, msg: "Новый текст!");