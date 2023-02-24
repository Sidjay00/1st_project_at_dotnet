int Max(int arg1, int arg2, int arg3)       // Создали функцию, которая вычисляет максимум из трех чисел.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {15, 21, 397, 12, 3, 33, 15, 23, 333};        // int[]  квадратными скобками сообщает, что создается массив

array[0] = 12;          // Присвоить нулевому значению массива новое значение.

// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2), 
//     Max(a3, b3, c3));       // Внутри агрумента можно передать функцию

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);