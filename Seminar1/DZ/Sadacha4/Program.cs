// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4.
// 8 -> 2, 4, 6, 8.

Console.Write("Введите целое число N ");
try
    {
        int x = Convert.ToInt32 (Console.ReadLine());
        if (x>0)
        {
            int i = 1;
            while (i<=x)
            {
                int b = i % 2;
                if (b == 0) Console.Write(i+", ");
                i++;
            }
        Console.WriteLine("Здесь все чётные числа от 1 до N");
        }
        else Console.WriteLine("Надо было ввести целое положительное число");
    }
catch
{
    Console.WriteLine("Надо было ввести целое положительное число");
}   