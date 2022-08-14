int a = 1;
int b = 43;
int c = 6;
int d = 10;
int e = 3;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
