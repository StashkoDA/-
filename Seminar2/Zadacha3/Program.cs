// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Crat() //Crat - это произвольное имя функции (кратность)
    {
    Console.WriteLine("Введите первое целое число ");
    try
    {
        int a = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите второе целое число ");
        int b = Convert.ToInt32 (Console.ReadLine());
        int c = b % a;
        if (c == 0) Console.WriteLine("Второе число кратно первому");
        else Console.WriteLine("Второе число не кратно первому, остаток "+c);
    }
    catch
    {
        Console.WriteLine("Надо было ввести целое число");
    }
    }
Crat();

// или:

// void numbers(int num1, int num2)
// {
// if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
// else Console.WriteLine($"Первое число не кратно второму, остаток {num1 % num2}");
//
// }
//
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()); - здесь равноценно вводу Convert.ToInt32 (Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
//
// numbers(num1, num2);
// Console.WriteLine();
