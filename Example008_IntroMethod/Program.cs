int Max(int arg1, int arg2, int arg3)       // Создали функцию, которая вычисляет максимум из трех чисел.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 397;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 152473;
int b3 = 23;
int c3 = 333;

// int max1 = Max(a1, b1, c1);         // Вызываем функцию Max, для того, чтобы определить максимум из первых трех чисел.
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));       // Внутри агрумента можно передать функцию

Console.WriteLine(max);