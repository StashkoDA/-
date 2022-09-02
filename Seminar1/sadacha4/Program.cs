//  Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите целое число ");
try
    {
        int x = Convert.ToInt32 (Console.ReadLine());
        if (x>0)
        {
            int i = -x;
            while (i<=x)
            {
                Console.Write(i+", ");
                i++;
            }
        }
        else if (x<0)
        {
            int i = x;
            while (i<=-x)
            {
                Console.Write(i+", ");
                i++;
            }
        }
        else Console.WriteLine("Вы ввели ноль");
    Console.WriteLine("Спасибо");
    }
catch
{
    Console.WriteLine("Надо было ввести целое число");
}   