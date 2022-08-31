int a = 1;
int b = 10;
int c = 8;
int d = 5;
int e = 100;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (d > max) max = d;
if (c > max) max = c;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);