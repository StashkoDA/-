// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число a и b");
int a = Convert.ToInt32 (Console.ReadLine());
int b = Convert.ToInt32 (Console.ReadLine());
int c = b*b;
Console.WriteLine("Квадрат числа b "+c);
if (c==a) Console.WriteLine("a квадрат числа b");
else if (c<a) Console.WriteLine("a не квадрат числа b");
else if (c>a) Console.WriteLine("a не квадрат числа b");
