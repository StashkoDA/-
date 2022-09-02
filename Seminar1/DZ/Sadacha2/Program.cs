// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7. 44 5 78 -> 78. 22 3 9 -> 22.

Console.WriteLine("Введите первое целое число ");
try
{
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите второе целое число ");
    int b = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Введите третье целое число ");
    int c = Convert.ToInt32 (Console.ReadLine());
    if (a>b)
        {
            if (a>c)
                {
                    Console.WriteLine("Первое число максимальное");
                }
            else Console.WriteLine("третье число максимальное");
        }
    else if (b>c)
        {         
            Console.WriteLine("Второе число максимальное");
        }
    else if (a==b)
        {
            if (b==c)
                {
                    Console.WriteLine("Числа равны");
                }
        }
    else Console.WriteLine("третье число максимальное");
}
catch
{
    Console.WriteLine("Надо было ввести целое число");
}
