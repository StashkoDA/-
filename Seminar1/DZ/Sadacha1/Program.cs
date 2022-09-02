// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7. a = 2 b = 10 -> max = 10. a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число ");
try
{
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите второе целое число ");
    int b = Convert.ToInt32 (Console.ReadLine());
    if (a>b)
    {
    Console.WriteLine("Первое число больше второго");
    }
    if (a<b)
    {
    Console.WriteLine("Второе число больше первого");
    }
    else Console.WriteLine("Числа равны");
}
catch
{
    Console.WriteLine("Надо было ввести целое число");
}