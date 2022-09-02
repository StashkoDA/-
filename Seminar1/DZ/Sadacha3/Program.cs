// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да. -3 -> нет. 7 -> нет.

Console.Write("Введите целое число ");
try
    {
    int x = Convert.ToInt32 (Console.ReadLine());
    int b = x % 2;
    if (b == 0)
        {
            Console.WriteLine("Число чётное");
        }
    else Console.WriteLine("Число нечётное");
    }
catch
{
    Console.WriteLine("Надо было ввести целое число");
}