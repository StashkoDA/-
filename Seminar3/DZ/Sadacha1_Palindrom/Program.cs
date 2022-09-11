// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет. 12821 -> да. 23432 -> да.

string Poli(int num)
    {
        string res;
        if (num < 100000 && num > 9999)
            {
                int a = num % 10;
                int b = num / 10000;
                int c = num / 10 % 10;
                int d = num / 1000 % 10;
                if (a==b & c==d) res = "это палиндромом";
                else res = "это не палиндромом";
            }
        else res = "Надо было вводить пятизначное число";
        return res;
    }
try
    {
        Console.Write ("Введите пятизначное число: ");
        int num = Convert.ToInt32 (Console.ReadLine());
        string rez = Poli(num);
        Console.WriteLine(rez);
    }
catch
    {
        Console.WriteLine("Надо было вводить пятизначное число");
    }

