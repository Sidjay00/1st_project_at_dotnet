int a = 1; // new Random().Next(1, 11);
int b = 8; // new Random().Next(1, 11);
int c = 3; // new Random().Next(1, 11);
int d = 2; // new Random().Next(1, 11);
int e = 6; // new Random().Next(1, 11);
Console.Write(a + ", ");
Console.Write(b + ", ");
Console.Write(c + ", ");
Console.Write(d + ", ");
Console.WriteLine(e + ".");

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine(max);