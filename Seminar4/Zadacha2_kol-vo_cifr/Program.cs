// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3; 78 -> 2; 89126 -> 5.

int Digit (int N)
    {

        int i = 0;
        while (N/((int)Math.Pow((Double)10,i))!=0) i++; // происходит деление N на 10 в степени пока не равно 0 в остатке целого числа.
        return i;
    }
try
    {
        Console.Write ("Введите целое число ");
        int a = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine($"Количество цифр в числе {a} равно {Digit(a)}");
    }
catch (System.Exception)
    {

        Console.WriteLine("Надо было вводить именно целое число!");
    }

    ////////// или
Console.Write ("Введите целое число ");
int N = Convert.ToInt32 (Console.ReadLine());
double to = 0;
to=Math.Floor(Math.Log10(N)+1);
Console.WriteLine("а это через логарифм...= "+to);